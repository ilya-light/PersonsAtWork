namespace Persons.UI
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PersonsList = new System.Windows.Forms.DataGridView();
            this.ShowPersonsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.PostComboBox = new System.Windows.Forms.ComboBox();
            this.DepComboBox = new System.Windows.Forms.ComboBox();
            this.DateFrom = new System.Windows.Forms.DateTimePicker();
            this.DateTo = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Option = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PersonsAtWork = new System.Windows.Forms.DataGridView();
            this.ShowButton2 = new System.Windows.Forms.Button();
            this.StatusComboBoxDates = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SortOptionBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PersonsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonsAtWork)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonsList
            // 
            this.PersonsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonsList.Location = new System.Drawing.Point(129, 47);
            this.PersonsList.Name = "PersonsList";
            this.PersonsList.Size = new System.Drawing.Size(753, 310);
            this.PersonsList.TabIndex = 0;
            // 
            // ShowPersonsButton
            // 
            this.ShowPersonsButton.Location = new System.Drawing.Point(664, 382);
            this.ShowPersonsButton.Name = "ShowPersonsButton";
            this.ShowPersonsButton.Size = new System.Drawing.Size(218, 41);
            this.ShowPersonsButton.TabIndex = 1;
            this.ShowPersonsButton.Text = "Show";
            this.ShowPersonsButton.UseVisualStyleBackColor = true;
            this.ShowPersonsButton.Click += new System.EventHandler(this.ShowPersonsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ФИО";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(23, 63);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 20);
            this.NameBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Статус";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Должность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Отдел";
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(23, 137);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(100, 21);
            this.StatusComboBox.TabIndex = 7;
            // 
            // PostComboBox
            // 
            this.PostComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PostComboBox.FormattingEnabled = true;
            this.PostComboBox.Location = new System.Drawing.Point(23, 194);
            this.PostComboBox.Name = "PostComboBox";
            this.PostComboBox.Size = new System.Drawing.Size(100, 21);
            this.PostComboBox.TabIndex = 8;
            // 
            // DepComboBox
            // 
            this.DepComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepComboBox.FormattingEnabled = true;
            this.DepComboBox.Location = new System.Drawing.Point(23, 250);
            this.DepComboBox.Name = "DepComboBox";
            this.DepComboBox.Size = new System.Drawing.Size(100, 21);
            this.DepComboBox.TabIndex = 9;
            // 
            // DateFrom
            // 
            this.DateFrom.Location = new System.Drawing.Point(23, 403);
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.Size = new System.Drawing.Size(200, 20);
            this.DateFrom.TabIndex = 10;
            // 
            // DateTo
            // 
            this.DateTo.Location = new System.Drawing.Point(23, 451);
            this.DateTo.Name = "DateTo";
            this.DateTo.Size = new System.Drawing.Size(200, 20);
            this.DateTo.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "С";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "По";
            // 
            // Option
            // 
            this.Option.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Option.FormattingEnabled = true;
            this.Option.Location = new System.Drawing.Point(23, 546);
            this.Option.Name = "Option";
            this.Option.Size = new System.Drawing.Size(100, 21);
            this.Option.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 530);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Уволенные/Принятые";
            // 
            // PersonsAtWork
            // 
            this.PersonsAtWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonsAtWork.Location = new System.Drawing.Point(249, 403);
            this.PersonsAtWork.Name = "PersonsAtWork";
            this.PersonsAtWork.Size = new System.Drawing.Size(240, 150);
            this.PersonsAtWork.TabIndex = 18;
            // 
            // ShowButton2
            // 
            this.ShowButton2.Location = new System.Drawing.Point(324, 568);
            this.ShowButton2.Name = "ShowButton2";
            this.ShowButton2.Size = new System.Drawing.Size(165, 35);
            this.ShowButton2.TabIndex = 19;
            this.ShowButton2.Text = "Show";
            this.ShowButton2.UseVisualStyleBackColor = true;
            this.ShowButton2.Click += new System.EventHandler(this.ShowButton2_Click);
            // 
            // StatusComboBoxDates
            // 
            this.StatusComboBoxDates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusComboBoxDates.FormattingEnabled = true;
            this.StatusComboBoxDates.Location = new System.Drawing.Point(23, 500);
            this.StatusComboBoxDates.Name = "StatusComboBoxDates";
            this.StatusComboBoxDates.Size = new System.Drawing.Size(121, 21);
            this.StatusComboBoxDates.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 484);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Статус";
            // 
            // SortOptionBox
            // 
            this.SortOptionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SortOptionBox.FormattingEnabled = true;
            this.SortOptionBox.Location = new System.Drawing.Point(522, 402);
            this.SortOptionBox.Name = "SortOptionBox";
            this.SortOptionBox.Size = new System.Drawing.Size(121, 21);
            this.SortOptionBox.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(522, 383);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Сортировать по";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(906, 627);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SortOptionBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.StatusComboBoxDates);
            this.Controls.Add(this.ShowButton2);
            this.Controls.Add(this.PersonsAtWork);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Option);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DateTo);
            this.Controls.Add(this.DateFrom);
            this.Controls.Add(this.DepComboBox);
            this.Controls.Add(this.PostComboBox);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowPersonsButton);
            this.Controls.Add(this.PersonsList);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PersonsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonsAtWork)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.DataGridView PersonsList;
        private System.Windows.Forms.Button ShowPersonsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.ComboBox PostComboBox;
        private System.Windows.Forms.ComboBox DepComboBox;
        private System.Windows.Forms.DateTimePicker DateFrom;
        private System.Windows.Forms.DateTimePicker DateTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Option;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView PersonsAtWork;
        public System.Windows.Forms.Button ShowButton2;
        private System.Windows.Forms.ComboBox StatusComboBoxDates;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox SortOptionBox;
        private System.Windows.Forms.Label label9;
    }
}

