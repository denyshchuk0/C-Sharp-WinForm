using System;
using System.Windows.Forms;

namespace Sudents
{
    public partial class Form1 : Form
    {
        StudentList list = new StudentList();
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker_Leave(object sender, EventArgs e)
        {
            TimeSpan time = DateTime.Today - dateTimePicker.Value;

            int days = time.Days / 365;

            this.lbAge.Text = "Age: " + days;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StudentList studentList = new StudentList();
            Student stud = new Student
            {
                Name = textName.Text,
                Surname = textSurname.Text,
                date = dateTimePicker.Value,
                Genger = comboBox.Text,
                Hobby = textHobby.Text

            };
            studentList.AddStud(stud);
            studentList.SaveToXml();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            list.Load();
            textName.Text = list.Stud[0].Name;
            textSurname.Text = list.Stud[0].Surname;
            dateTimePicker.Value = list.Stud[0].date;
            comboBox.Text = list.Stud[0].Genger;
            textHobby.Text = list.Stud[0].Hobby;
            MessageBox.Show("Completed!", "Load", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void lbAge_Click(object sender, EventArgs e)
        {

        }
    }
}
