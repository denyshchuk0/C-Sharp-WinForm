using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();

            Button button = new Button();
            button.Text="dd";
            button.Size = new Size(20, 40);
            button.Location = new Point(100, 100);
           
            button.Click += Button_Click;

            form.Controls.Add(button);
            form.ShowDialog();
        }

        private static void Button_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Blue;
        }
    }
}
