using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pazzle
{
    public partial class Pazzle : Form
    {
        public Pazzle()
        {
            InitializeComponent();
            pictureBox1.AllowDrop = true;
            pictureBox2.AllowDrop = true;
            pictureBox3.AllowDrop = true;
            pictureBox4.AllowDrop = true;
            pictureBox5.AllowDrop = true;
            pictureBox6.AllowDrop = true;
            pictureBox7.AllowDrop = true;
            pictureBox8.AllowDrop = true;
            pictureBox9.AllowDrop = true;
        }

        private void Pazzle_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                object data = e.Data.GetData(DataFormats.FileDrop);
                string fileName = ((string[])data)[0];
                pb.Image = Image.FromFile(fileName);
            }
        }

        private void tableLayoutPanel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            pb.DoDragDrop(pb, DragDropEffects.Copy);
        }
    }
}
