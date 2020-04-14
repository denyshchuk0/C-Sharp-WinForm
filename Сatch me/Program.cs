using System;
using System.Drawing;
using System.Windows.Forms;

namespace Сatch_me
{
    class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();
            form.Text = "First button";
            form.BackColor = Color.Beige;

            Button button = new Button();
            button.Text = "Increase Opacity";
            button.Size = new Size(100, 40);
            button.Top = 150;
            button.Left = 100;
            form.Controls.Add(button);
        }

    }
}
