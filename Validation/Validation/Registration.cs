using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Validation
{
    public partial class Registration : Form
    {
    
        public Registration()
        {
            InitializeComponent();
        }
        private void AllValidate(TextBox tb)
        {
            if (String.IsNullOrEmpty(tb.Text))
                errorProvider.SetError(tb, "Fild not entered!");
            else
                errorProvider.Clear();
        }
        private void TextValidate(TextBox tb)
        {
            string tmp = tb.Text;
            bool findNum = false;

            for (int i = 0; i < tmp.Length; i++)
            {
                if (Char.IsNumber(tmp[i]) == true)
                    findNum = true;
            }
            if (findNum == true)
                errorProvider.SetError(tb, "Fild has number!");
            AllValidate(tb);
        }
        private void NumValidate(TextBox tb)
        {
            string tmp = tb.Text;
            //int findLeter = ;
            //AllValidate(tb);

            
            //if (findLeter == true)
            //    errorProvider.SetError(tb, "Has leter!");

        }
        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            TextValidate(tbName);
        }

        private void tbSurname_Validating(object sender, CancelEventArgs e)
        {
            TextValidate(tbSurname);
        }

        private void tbNumber_Validating(object sender, CancelEventArgs e)
        {
            NumValidate(tbNumber);
            if (tbNumber.Text.Length != 10 || tbNumber.Text[0] != '0')
                errorProvider.SetError(tbNumber, "Number not corect! (0*********)");
        }

        private void tbBirth_Validating(object sender, CancelEventArgs e)
        {
            NumValidate(tbBirth);
            int age = 0;
            if (string.IsNullOrEmpty(tbBirth.Text))
            {
                tbBirth.Text = "0";
                return;
            }

            if (!Int32.TryParse(tbBirth.Text, out age))
                    errorProvider.SetError(tbBirth, "Minimal 12 age!");
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            errorProvider.GetError(tbBirth);
        }
    }
}
