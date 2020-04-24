using System;
using System.Windows.Forms;

namespace Calkulator
{
    public partial class Calculator : Form
    {

        string tmp = " ";
        bool plus = false;
        bool minus = false;
        bool multupiy = false;
        bool divide = false;

        double a = 0;
        double b = 0;
        double res = 0;

        public Calculator()
        {
            InitializeComponent();
        }
        //1..9
        #region
        private void btn1_Click(object sender, EventArgs e)
        {
            if (tbScrean.Text == "0")
            {
                tbScrean.Clear();
            }
            tbScrean.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (tbScrean.Text == "0")
            {
                tbScrean.Clear();
            }
            tbScrean.Text += "2";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (tbScrean.Text == "0")
            {
                tbScrean.Clear();
            }
            tbScrean.Text += "0";
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (tbScrean.Text.Contains(",") == false)
                tbScrean.Text += ",";

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (tbScrean.Text == "0")
            {
                tbScrean.Clear();
            }
            tbScrean.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (tbScrean.Text == "0")
            {
                tbScrean.Clear();
            }
            tbScrean.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (tbScrean.Text == "0")
            {
                tbScrean.Clear();
            }
            tbScrean.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (tbScrean.Text == "0")
            {
                tbScrean.Clear();
            }
            tbScrean.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (tbScrean.Text == "0")
            {
                tbScrean.Clear();
            }
            tbScrean.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (tbScrean.Text == "0")
            {
                tbScrean.Clear();
            }
            tbScrean.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (tbScrean.Text == "0")
            {
                tbScrean.Clear();
            }
            tbScrean.Text += "9";
        }
        #endregion 

        private void btnE_Click(object sender, EventArgs e)
        {
            tmp = tbScrean.Text;
            b = Convert.ToDouble(tmp);
            if (plus == true)
            {
                res = a + b;
                plus = false;
            }
            if (minus == true)
            {
                res = a - b;
                minus = false;
            }
            if (multupiy == true)
            {
                res = a * b;
                multupiy = false;
            }
            if (divide == true)
            {

                if (b == 0)
                {
                    MessageBox.Show("Divide by zero!!!",
                   "ERROR",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1,
                   MessageBoxOptions.DefaultDesktopOnly);
                }
                else
                {
                    res = a / b;
                }
            }
            tbScrean.Text = res.ToString();
        }
        // + - * / and otrer button
        #region 
        private void Operation()
        {
            tmp = tbScrean.Text;
            a = Convert.ToDouble(tmp);
            tbScrean.Text = "0";
        }
        private void btnP_Click(object sender, EventArgs e)
        {
            infoLb.Text = "addition";
            Operation();
            plus = true;

        }
        private void btnM_Click(object sender, EventArgs e)
        {
            infoLb.Text = "minus";
            Operation();
            minus = true;
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            infoLb.Text = "multuply";
            Operation();
            multupiy = true;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            infoLb.Text = "divide";
            Operation();
            divide = true;
        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            if (tbScrean.Text.Length == 1)
            {
                tbScrean.Text = "0";
            }
            else
            {
                tbScrean.Text = tbScrean.Text.Substring(0, tbScrean.Text.Length - 1);
            }
        }

        private void btnCA_Click(object sender, EventArgs e)
        {
            tbScrean.Text = "0";
            a = 0;
            b = 0;
            res = 0;
            plus = false;
            minus = false;
            multupiy = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbScrean.Text = "0";
        }

        private void tbScrean_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)13)
            {
                btnE_Click(sender, e);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string tmpStr = tbScrean.Text;
            double digits = Convert.ToDouble(tmpStr);
            digits = digits * -1;
            tmpStr = digits.ToString();
            tbScrean.Text = tmpStr;
        }
        #endregion

        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                btnChange_Click(sender, e);
            }
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            tbScrean.Focus();
        }
    }
}
