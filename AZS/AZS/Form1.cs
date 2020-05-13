using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AZS
{
    public partial class BestOill : Form
    {
        Dictionary<string, double> gas = new Dictionary<string, double>();
        int hotDog = 0;
        int gamburger = 0;
        int kartoshkaFri = 0;
        int cola = 0;
        int i = 0;
        double sum = 0;
        public BestOill()
        {
            InitializeComponent();
            gas.Add("A-76", 13.5);
            gas.Add("A-95", 20.4);
            cbGas.Items.AddRange(gas.Keys.ToArray());

            cbGas.Text = cbGas.Items[0].ToString();
            tbCoastCola.Text = "25";
            tbCoastGam.Text = "15";
            tbCoastHdog.Text = "10";
            tbCoastPot.Text = "13";
            lbSumMC.Text = "0";
        }
        private void cbGas_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var dict in gas)
                if (cbGas.SelectedItem.ToString() == dict.Key)
                {
                    tbCoastGas.Text = dict.Value.ToString();
                    lbSumaGS.Text = dict.Value.ToString();
                }
        }

        private void ChekSum(RadioButton rb, TextBox tb1, TextBox tb2)
        {
            if (rb.Checked == true)
            {
                tb1.ReadOnly = false;
                tb2.ReadOnly = true;
                tb2.Text = "";
            }
        }
        private void rbLiters_CheckedChanged(object sender, EventArgs e) => ChekSum(rbLiters, tbLiters, tbSuma);
        private void rbSuma_CheckedChanged(object sender, EventArgs e) => ChekSum(rbSuma, tbSuma, tbLiters);
        private void tbLiters_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbLiters.Text))
                lbSumaGS.Text = tbCoastGas.Text;
            else
                lbSumaGS.Text = (Convert.ToDouble(tbLiters.Text) * Convert.ToDouble(tbCoastGas.Text)).ToString();
        }

        private void tbSuma_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbSuma.Text))
                lbSumaGS.Text = tbCoastGas.Text;
            else
                lbSumaGS.Text = tbSuma.Text;
        }

        private void CheckedChange(CheckBox cb, NumericUpDown nud, ref int pr, TextBox tb)
        {
            if (cb.Checked)
            {
                nud.ReadOnly = false;
                pr = Convert.ToInt32(tb.Text) * Convert.ToInt32(nud.Value);
            }
            else
            {
                nud.ReadOnly = true;
                pr = 0;
            }
            ResalFoods();
        }
        private void cbHotdog_CheckedChanged(object sender, EventArgs e) =>
            CheckedChange(cbHotdog, numericUpDownHotdog, ref hotDog, tbCoastHdog);
        private void cbGamb_CheckedChanged(object sender, EventArgs e) =>
           CheckedChange(cbGamb, numericUpDownGamb, ref gamburger, tbCoastGam);
        private void cbFriPotato_CheckedChanged(object sender, EventArgs e) =>
            CheckedChange(cbFriPotato, numericUpDownFriPotato, ref kartoshkaFri, tbCoastPot);
        private void cbCola_CheckedChanged(object sender, EventArgs e) =>
            CheckedChange(cbCola, numericUpDownCola, ref cola, tbCoastCola);
        private void ResalFoods() =>
            lbSumMC.Text = (hotDog + gamburger + kartoshkaFri + cola).ToString();
        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            cbHotdog_CheckedChanged(null, null);
            cbGamb_CheckedChanged(null, null);
            cbFriPotato_CheckedChanged(null, null);
            cbCola_CheckedChanged(null, null);
            ResalFoods();
        }
        private void forPayAll_Click(object sender, EventArgs e)
        {
            lbSumALL.Text = (Convert.ToDouble(lbSumMC.Text) + Convert.ToDouble(lbSumaGS.Text)).ToString();
            sum += Convert.ToDouble(lbSumALL.Text);
            timer.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 100)
            {
                timer.Stop();
                MessageBox.Show("Contine?", "Clear", MessageBoxButtons.OKCancel);
                timer.Start();
            }
            if (DialogResult == DialogResult.OK)
            {
                ClearAll();
                timer.Stop();
                i = 0;
            }
            else if (i == 202)
                ClearAll();
        }
        private void ClearAll()
        {
            foreach (var nud in Controls.OfType<NumericUpDown>()) nud.Value = 0;
            foreach (var cb in Controls.OfType<CheckBox>()) cb.Checked = false;

            tbLiters.Text = "";
            tbSuma.Text = "";
            rbLiters.Checked = false;
            rbSuma.Checked = false;
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e) =>
            MessageBox.Show($"Resault: {sum}", "All Resault");
    }
}
