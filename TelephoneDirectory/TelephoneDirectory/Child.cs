using System;
using System.Drawing;
using System.Windows.Forms;

namespace TelephoneDirectory
{
    public partial class Child : Form
    {
        private Perent mainForm = null;
        public Child(Form callingForm, People contact)
        {
            InitializeComponent();
            mainForm = callingForm as Perent;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool findNum = false;
            for (int i = 0; i < tbName.Text.Length; i++)
            {
                if (Char.IsNumber(tbName.Text[i]) == true)
                    findNum = true;
            }
            if (findNum == true)
                errorProvider.SetError(tbName, "Fild has number!");
            if (String.IsNullOrEmpty(tbName.Text))
                errorProvider.SetError(tbName, "Fild not entered!");
            if (String.IsNullOrEmpty(tbNumber.Text))
                errorProvider.SetError(tbNumber, "Fild not entered!");
            if (tbNumber.Text.Length != 10 || tbNumber.Text[0] != '0')
                errorProvider.SetError(tbNumber, "Number not corect! (0*********)");
            else
            {
                errorProvider.Clear();
                this.mainForm.ListText = tbName.Text + " " + tbNumber.Text;
            }

        }
        private void btnEnterPicture_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(openFileDialog.FileName);
                this.mainForm.IL = openFileDialog.FileName;
            }
        }
    }
}
