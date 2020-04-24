using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Anketa
{
    public partial class Form1 : Form
    {
        PeopleList peopleList = new PeopleList();
        List<string> leng = new List<string>();
        string gender = "";
        string tmp = " ";

        public Form1()
        {
            InitializeComponent();
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

            People p = new People
            {
                Name = textName.Text,
                date = dateTimePicker1.Value,
                Genger = gender,
                Lang = leng

            };
            peopleList.AddPeop(p);
            peopleList.SaveToXml();
           
            this.groupBox.Text = textName.Text;
          //  this.listBox.Items.Add(p.ToString());
            this.listBox.Items.Add("Date:" + dateTimePicker1.Value.Date);
            this.listBox.Items.Add("Gender: "+ gender);
            leng.ForEach(delegate (String a) {
                tmp += a+"  ";
            });
            this.listBox.Items.Add("Knoleg: "+ tmp);

            if (radioButton2.Checked)
            {
                pictureBox.Image = Image.FromFile("../../img/M.png");
            }
            else
            {
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

        private void btnLoad_Click(object sender, EventArgs e)
        {
            peopleList.Load();
            this.groupBox.Text = peopleList.peoples[0].Name;
            this.listBox.Items.Add("Date:" + peopleList.peoples[0].date);
            this.listBox.Items.Add("Gender: " + peopleList.peoples[0].Genger);
            peopleList.peoples[0].Lang.ForEach(delegate (String a) {
                tmp += a + "  ";
            });
            this.listBox.Items.Add("Knoleg: " + tmp);
            if (peopleList.peoples[0].Genger=="Male")
            {
                pictureBox.Image = Image.FromFile("../../img/M.png");
            }
            else
            {
                pictureBox.Image = Image.FromFile("../../img/F.png");
            }
        }
    }
}
