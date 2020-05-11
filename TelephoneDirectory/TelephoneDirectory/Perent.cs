using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TelephoneDirectory
{
    public partial class Perent : Form
    {
        public People people = null;
        public List<People> peoples = new List<People>();
        public Perent()
        {
            InitializeComponent();

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            people = new People();
            Child addform = new Child(this, people);
            addform.Show();

        }
        public string ListText { set { lbCatalog.Items.Add(value); } }

        public string IL { set { imageList.Images.Add(Image.FromFile(value)); } }

        private void lbCatalog_SelectedValueChanged(object sender, EventArgs e)
        {
            if (imageList.Images.Count == 0)
                return;
            pictureBox.Image = imageList.Images[lbCatalog.SelectedIndex];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbCatalog.SelectedIndex == -1)
            {
                MessageBox.Show("No select contact ...");
                return;
            }
            imageList.Images.RemoveAt(lbCatalog.SelectedIndex);
            lbCatalog.Items.RemoveAt(lbCatalog.SelectedIndex);
            pictureBox.Image = null;
        }

        private void btnAllDelete_Click(object sender, EventArgs e)
        {
            if (lbCatalog.SelectedIndex == -1)
            {
                MessageBox.Show("Empty...");
                return;
            }
            imageList.Images.Clear();
            lbCatalog.Items.Clear();
            pictureBox.Image = null;
        }
    }
}
