using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace City
{
    public partial class Citys : Form
    {
        public Citys()
        {
            InitializeComponent();

            hScrollBar.Maximum = iLKiev.Images.Count - 1;
            hScrollBar.LargeChange = hScrollBar.SmallChange = 1;
            pictureBox.Image = iLKiev.Images[0];
            cbCitys.Text = cbCitys.Items[0].ToString();
        }

        private void hScrollBar_ValueChanged(object sender, EventArgs e)
        {
            
            int j = hScrollBar.Value; 
            pictureBox.Image = il.Images[j];
        }

        private void cbCitys_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCitys.SelectedIndex ==0) {
                
            }
        }
    }
}
