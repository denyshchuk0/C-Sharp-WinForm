using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventPlanner2
{
    public partial class Planner : Form
    {
        List<Event> events = new List<Event>();
        string priority;
        public Planner()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Event eve = new Event
            {
                EventText = tbEvent.Text,
                Date = dateTimePicker.Value,
                Priority = priority
            };

            events.Add(eve);
            listBox.Items.Add(eve);
           
        }

        private void rbLow_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb.Checked) {
                priority = rb.Text;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            listBox.ClearSelected();
        }
    }
 } 
