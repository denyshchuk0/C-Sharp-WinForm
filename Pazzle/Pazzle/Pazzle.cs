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
        Image tmpImage;
        PictureBox tempBox;
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
        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            tempBox.Image = pb.Image;
            pb.Image = tmpImage;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            tmpImage = pb.Image;
            tempBox = pb;
            pb.DoDragDrop(pb, DragDropEffects.Copy);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int[] mas = new int[8];
            for (int i = 0; i < 8; i++)
            {
                int a = rnd.Next(1, 9);
                if (!mas.Contains(a))
                {
                    mas[i] = a;
                }
                else
                    i--;
            }
            int f = 0;
            string name;
            foreach (PictureBox item in tableLayoutPanel1.Controls.OfType<PictureBox>())
            {
                if (f < 8)
                {
                    name = mas[f].ToString();
                    item.Image = Image.FromFile($"../../img/{name}.jpg");
                    f++;
                }
            }
        }
        private void btnComplste_Click(object sender, EventArgs e)
        {
            //int i = 8;
            //string name;
            //bool complite = false;
            //foreach (PictureBox item in tableLayoutPanel1.Controls.OfType<PictureBox>())
            //{
                //        if (i > 1)
                //        {
                //            name = i.ToString();
                //            if (i == 4) { i-=2; continue; }
                //            if (item.Tag.ToString() != name)
                //            {
                //                MessageBox.Show("NOT COMPLIT", "NOT COMPLITE");
                //                  return;
                //            }

                //            else
                //            {
                //                complite = true;
                //            }
                //            i--;
                //        }

                //    }
                //    if(i==1 && complite==true )
                //        MessageBox.Show("COMPLIT", "COMPLITE");
            //}
        }
    }
}
