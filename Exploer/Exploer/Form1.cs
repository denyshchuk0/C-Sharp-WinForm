using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exploer
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
            listView.ContextMenuStrip = contextMenuStrip;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog() { Description = "Enter papky" };
            if (fd.ShowDialog() == DialogResult.OK) {
                string path = fd.SelectedPath;
                tbPath.Text = path;
                string[] files = Directory.GetFiles(path);
                foreach (string file in files)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = file.Remove(0, file.LastIndexOf('\\') + 1);
                    listView.Items.Add(lvi);
                }
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip_Click(object sender, EventArgs e)
        {

        }

        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    } 
}
