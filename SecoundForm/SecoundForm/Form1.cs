using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_11___Winform_Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int i = 0;
        
        private void btnStart_Click(object sender, EventArgs e)
        {       

            Point point = lbTime.Location;
            timer.Start();
            if (point.Y > btnStart.Location.Y - lbTime.Height - 10)
            {
                point.Y = btnStart.Location.Y - lbTime.Height - 10;
            }
            if (point.X<20 && point.Y != 26)
            {
                point.X = 10;
            }
            if (point.Y<20)
            {
                point.Y = 26;
            }

            if (point.X < ClientSize.Width - lbTime.Width - 20 && point.Y < btnStart.Location.Y - lbTime.Height - 10 && point.Y == 26)
            { 
                lbTime.Location = new Point(point.X + 20, point.Y); 
            }

            if (point.X > ClientSize.Width - lbTime.Width - 20 && point.Y < btnStart.Location.Y - lbTime.Height - 10)
            {
                lbTime.Location = new Point(point.X, point.Y + 20);
            }

            else if (point.Y == btnStart.Location.Y - lbTime.Height - 10 && point.X > 20)
            {
                lbTime.Location = new Point(point.X - 20, point.Y);
            }
            else if (point.X == 10)
            {
                lbTime.Location = new Point(point.X, point.Y - 20);
            }
            else if (point.X == 10 && point.Y != 26)
            {
                lbTime.Location = new Point(point.X, point.Y - 20);
            }

            lbTime.Text = ++i + " sec";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Point point = lbTime.Location;
            timer.Stop();

        }
    }
}
