using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAM
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
            openFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            ChildForm child = new ChildForm();
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                child.Path = openFileDialog.FileName;
            }
            child.Show(); 
        }
    }
}
