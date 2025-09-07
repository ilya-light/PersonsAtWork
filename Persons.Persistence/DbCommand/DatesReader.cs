using Persons.App.Common;
using Persons.Domain.Models;
using System;
using System.Collections.Generic;

namespace Persons.Persistence.DbCommand
{
    public class DatesReader : Repository, IDatesReader
    {
        public List<Dates> ReadDatesCount(bool uneployed, DateTime from, DateTime to, string status)
        {
            var dates = new List<Dates>();

            string command = uneployed ? "GetUneploy" : "GetEmploy";
            InitCommand(command);
            _command.Parameters.AddWithValue("@date_from", from);
            _command.Parameters.AddWithValue("@date_to", to);
            _command.Parameters.AddWithValue("@status_filter", status);
            using (var reader = _command.ExecuteReader())
            {
                while (reader.Read())
                {
                    dates.Add(new Dates()
                    { 
                        Date = DateTime.Parse(reader[0].ToString()),
                        Count = int.Parse(reader[1].ToString()) 
                    });
                }
            }
            DisposeCommand();
            return dates;
        }
    }
}
