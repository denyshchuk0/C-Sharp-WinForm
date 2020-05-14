using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAM
{
    public partial class ChildForm : Form
    {
        List<Test> testsList = new List<Test>();
        int nextCount = 0;
        int ball = 0;
        public string Path { get; set; }
        public ChildForm()
        {
            InitializeComponent();
        }

        private void ChildForm_Load(object sender, EventArgs e)
        {
            Test test;
            var lines = File.ReadAllLines(Path);

            int trueCount;
            for (int i = 0; i < lines.Length; i++)
            {
                trueCount = 0;
                test = new Test();
                test.Question = lines[i];
                i++;

                while (lines[i] != "*")
                {
                    test.Answers.Add(lines[i++]);
                    if (lines[i - 1].Contains(" 1") == true)
                    {
                        trueCount++;
                        test.Сorrectness.Add(true);
                    }
                    else
                        test.Сorrectness.Add(false);
                }
                test.trueCount = trueCount;
                testsList.Add(test);
            }
            textTest.Text = "Press Next to start";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string addItem;
            if (nextCount == testsList.Count)
            {
                CheckBall();
                EndTest();
            }
            else
            {
                CheckBall();
                checkedListBox.Items.Clear();
                groupBoxTest.Text = "question #" + (nextCount + 1).ToString();
                textTest.Text = testsList[nextCount].Question;

                for (int i = 0; i < testsList[nextCount].Answers.Count; i++)
                {
                    addItem = testsList[nextCount].Answers[i].Substring(0, testsList[nextCount].Answers[i].Length - 1);
                    checkedListBox.Items.Add(addItem);
                }
                this.nextCount++;
            }
        }

        private void EndTest()
        {
            btnNext.Enabled = false;
            double percent = (ball * 100) / testsList.Count;
            textTest.Text = "Your ball = " + ball.ToString() + " is " + percent.ToString() + "%";
            MessageBox.Show(ball.ToString() + "/" + testsList.Count.ToString(), "complite!!!");
        }

        private void CheckBall()
        {
            CheckedListBox cb = checkedListBox;
            bool exselent = false;
            for (int i = 0; i < cb.CheckedItems.Count; i++)
            {
                for (int j = 0; j < testsList[nextCount - 1].Answers.Count; j++)
                    if ((cb.CheckedItems[i] + "1") == testsList[nextCount - 1].Answers[j] && testsList[nextCount - 1].Сorrectness[j] == true)
                        if (cb.CheckedItems.Count == testsList[nextCount - 1].trueCount)
                            exselent = true;
            }
            if (exselent) ball++;
        }
    }
}
