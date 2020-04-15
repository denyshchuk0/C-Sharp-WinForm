using System;
using System.Windows.Forms;

namespace millioner
{
    public partial class Form1 : Form
    {
        Quiz quiz = new Quiz();
        bool yes = false;
        bool no = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Question question0 = new Question("Yes or no ? ");
            Question question1 = new Question("What is microfone ? ");
            Question question2 = new Question("Are you live ? ");
            Question question3 = new Question("What is love ? ");
            Question question4 = new Question("Baby dont hurt me ?");
            Question question5 = new Question("No more ?");

            quiz.AddQuestion(question0);
            quiz.AddQuestion(question1);
            quiz.AddQuestion(question2);
            quiz.AddQuestion(question3);
            quiz.AddQuestion(question4);
            quiz.AddQuestion(question5);

            quiz.Run(lbText, yes, no);
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            yes = true;
            quiz.Run(lbText, yes, no);
            yes = false;

        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            no = true;
            quiz.Run(lbText, yes, no);
            no = false;
        }
    }
}
