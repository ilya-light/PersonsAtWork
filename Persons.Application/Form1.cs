using Persons.App.Common;
using Persons.App.Persons;
using Persons.Domain.Models;
using Persons.Persistence.DbCommand;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Persons.UI
{
    public partial class Form1 : Form
    {
        private BindingSource _peopleSource = new BindingSource();
        private BindingSource _datesSource = new BindingSource();

        private List<Person> _people = new List<Person>();
        private List<Dates> _dates = new List<Dates>();

        private IPersonsReader _personReader = new PersonsReader();
        private IStringsReader _stringsReader = new StringsReader();
        private IDatesReader _dateReader = new DatesReader();

        public Form1()
        {
            InitializeComponent();

            List<string> statuses = _stringsReader.GetStrings("Statuses");
            statuses.Add("");

            StatusComboBox.Items.AddRange(statuses.ToArray());
            StatusComboBoxDates.Items.AddRange(statuses.ToArray());
            DepComboBox.Items.AddRange(_stringsReader.GetStrings("Deps").Append("").ToArray());
            PostComboBox.Items.AddRange(_stringsReader.GetStrings("Posts").Append("").ToArray());
            
            SortOptionBox.Items.AddRange(typeof(Person).GetProperties().Select(p => p.Name).Append("").ToArray());
            Option.Items.AddRange(new object[] { "Принят", "Уволен" });

            PersonsList.DataSource = _peopleSource;
            PersonsAtWork.DataSource = _datesSource;
        }

        private void ShowPersonsButton_Click(object sender, EventArgs e)
        {
            _people = _personReader.GetPeople();

            var currentPersons = FilterPersons();
            currentPersons = OrderByPersons(currentPersons);

            _people = currentPersons.ToList();
            _peopleSource.DataSource = _people;

            DrawUneployed();
        }

        private void ShowButton2_Click(object sender, EventArgs e)
        {
            DateTime from = DateFrom.Value;
            DateTime to = DateTo.Value;
            bool uneployed = Option.SelectedIndex == 0 ? false : true;
            string status = StatusComboBoxDates.Text;

            _dates = _dateReader.ReadDatesCount(uneployed, from, to, status);

            _datesSource.DataSource = _dates;
        }

        private IEnumerable<Person> FilterPersons()
        {
            string depFilter = DepComboBox.Text;
            string statusFilter = StatusComboBox.Text;
            string postFilter = PostComboBox.Text;
            string nameFilter = NameBox.Text;

            var filter = _people.
                Where(p => depFilter == "" || p.Department == depFilter.ToString()).
                Where(p => statusFilter == "" || p.Status == statusFilter.ToString()).
                Where(p => postFilter == "" || p.Post == postFilter.ToString()).
                Where(p => nameFilter == "" || p.Name.Contains(nameFilter));

            return filter;
        }

        private IEnumerable<Person> OrderByPersons(IEnumerable<Person> people)
        {
            string orderBy = SortOptionBox.Text;
            switch (orderBy)
            {
                case "Name":
                    people = people.OrderBy(p => p.Name);
                    break;
                case "Status":
                    people = people.OrderBy(p => p.Status);
                    break;
                case "Department":
                    people = people.OrderBy(p => p.Department);
                    break;
                case "Post":
                    people = people.OrderBy(p => p.Post);
                    break;
                case "DateEmploy":
                    people = people.OrderBy(p => p.DateEmploy);
                    break;
                case "DateUnemploy":
                    people = people.OrderBy(p => p.DateUnemploy);
                    break;
            }
            return people;
        }

        private void DrawUneployed()
        {
            foreach (DataGridViewRow row in PersonsList.Rows)
            {
                if (row.Cells[2].Value != null)
                {
                    row.Cells[0].Style.BackColor = Color.Tomato;
                }
            }
        }
    }
}
