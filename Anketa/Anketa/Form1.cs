using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anketa
{
    public partial class Form1 : Form
    {
        PeopleList list = new PeopleList();
        List<string> leng = new List<string>();
        string gender = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                gender = rb.Text;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            PeopleList peopleList = new PeopleList();
            People p = new People
            {
                Name = textName.Text,
                date = dateTimePicker1.Value,
                Genger = gender,
                Lang = leng

            };
            peopleList.AddStud(p);
            peopleList.SaveToXml();

            this.groupBox.Text = textName.Text;
            //this.listBox.Items.Add(textName.Text);
            this.listBox.Items.Add("Date:" + dateTimePicker1.Value);
            this.listBox.Items.Add("Gender: "+ gender);
            this.listBox.Items.Add("Knoleg: "+ leng);

            if (radioButton2.Checked)
            {
                pictureBox.Image = Image.FromFile("../../img/M.png");
            }
            else {
                pictureBox.Image = Image.FromFile("../../img/F.png");
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked)
            {
                leng.Add(cb.Text);
            }
        }
    }
}
