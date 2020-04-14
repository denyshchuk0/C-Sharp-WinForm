using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace millioner
{
    public partial class Form1 : Form
    {
        Quiz quiz = new Quiz();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Question question0 = new Question("You or no ? ");
            Question question1 = new Question("What is microfone ? ");
            Question question2 = new Question("Are you live ? ");
            Question question3 = new Question("What is love ? ");
            Question question4 = new Question("Baby dont hert me ?");
            Question question5 = new Question("No more ?");

            quiz.AddQuestion(question0);
            quiz.AddQuestion(question1);
            quiz.AddQuestion(question2);
            quiz.AddQuestion(question3);
            quiz.AddQuestion(question4);
            quiz.AddQuestion(question5);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
           // panel1.Visible = false;
           // btnNext_Click(sender, null);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            quiz.Run(lbText, btnYes, btnNo);
 
        }
        private void btnResult_Click(object sender, EventArgs e)
        {
            MessageBox.Show($" YES : {quiz.yes} \n NO : {quiz.no}");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
           
        }
    }
}
