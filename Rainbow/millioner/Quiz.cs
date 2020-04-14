using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace millioner
{
    class Quiz
    {
        List<Question> questions = new List<Question>();
        public int yes { get; private set; } = 0;
        public int no { get; private set; } = 0;
        int index = 0;
        public void AddQuestion(Question q)
        {
            questions.Add(q);
        }

        public void Run(Label lbText, Button Yes, Button No)
        {
           
            try
            {
                
                if (Yes.Focused)
                {
                    questions[index].reply = true;
                    yes++;
                    index++;
                }
                else if (No.Focused )
                {
                    questions[index].reply = false;
                    no++;
                    index++;
                }

                lbText.Text = questions[index].ToString();

            }
            catch (Exception)
            {

                MessageBox.Show($"You result\n YES : {yes} \n NO : {no}");
                Yes.Enabled = false;
                No.Enabled = false;
                Yes.Enabled = false;
                No.Enabled = false;
            }
        }
    }
}
