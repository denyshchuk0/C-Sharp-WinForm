using System;
using System.Drawing;
using System.Windows.Forms;

namespace Rainbow
{
    class Program
    {
        static int counter = 0;
        static Color[] colors = { Color.Red, Color.Orange, Color.LightBlue, Color.Green, Color.Yellow, Color.Blue, Color.DarkViolet };
        static int index = 0;
        static void Main(string[] args)
        {
            Form form = new Form();
            form.Text = "Start to click";
            form.BackColor = Color.White;
            form.Size = new Size(300, 200);

            Button b1 = new Button();
            b1.Text = "Click me";
            b1.Size = new Size(40, 40);
            b1.Top = form.Height / 2 - b1.Height;
            b1.Left = form.Width / 2 - b1.Width * 2;
            form.Controls.Add(b1);

            Button b2 = new Button();
            b2.Text = "Null";
            b2.Size = new Size(40, 40);
            b2.Top = form.Height / 2 - b2.Height;
            b2.Left = form.Width - b2.Width * 3;
            form.Controls.Add(b2);

            b1.MouseClick += B1_MouseClick;
            b2.MouseClick += B2_MouseClick;

            form.MouseClick += Form_MouseClick;

            form.ShowDialog();
        }

        private static void Form_MouseClick(object sender, MouseEventArgs e)
        {
            (sender as Form).BackColor = colors[index++];
            if (index == colors.Length) index = 0;
        }

        private static void B2_MouseClick(object sender, MouseEventArgs e)
        {
            counter = 0;
            ((sender as Button).Parent as Form).Text = Convert.ToString(counter);
        }

        private static void B1_MouseClick(object sender, MouseEventArgs e)
        {
            counter++;
            ((sender as Button).Parent as Form).Text = Convert.ToString(counter);
        }
    }
}
