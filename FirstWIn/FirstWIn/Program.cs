using System;
using System.Drawing;
using System.Windows.Forms;

namespace WF_02
{
    class Program
    {
//        Написати програму, яка міститиме дві кнопки: Increase Opacity, Decrease Opacity
//Перша при клікові буде збільшувати прозорість форми, друга - зменшувати
        static void Main(string[] args)
        {
            Form form = new Form();
            form.Text = "First button";
            form.BackColor = Color.Beige;

            Button button = new Button();
            button.Text = "Decrease Opacity";
            button.Size = new Size(100, 40);
            button.Top = 150 ;
            button.Left = 100 ;
            form.Controls.Add(button);
            button.Click += Button1_Click;

            Button button2 = new Button();
            button2.Text = "Increase Opacity";
            button2.Size = new Size(100, 40);
            button2.Top = 100;
            button2.Left = 100;
            form.Controls.Add(button2);
            button2.Click += Button2_Click;
            form.ShowDialog();
        }
        private static void Button1_Click(object sender, EventArgs e)
        {
            ((sender as Button).Parent as Form).Opacity -=0.1;
        }
        private static void Button2_Click(object sender, EventArgs e)
        {
            ((sender as Button).Parent as Form).Opacity += 0.1;
        }
    }
}