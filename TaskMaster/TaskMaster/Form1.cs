using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskMaster
{
    public partial class TaskManager : Form
    {
        //        Створити програму "Планування подій(справ)"(Version 1.0).
        //На головній формі розмістити 
        // 	- текстове поле для введення назви події(справи), обов'язкове поле
        //	- текстове поле для місця події(не обов'язкове)
        //	- DateTimePicker або MonthCalendar для вибору дати події(по замовчуванню на завтра)
        //	- текстове поле для вибору пріоритут події(встановити властивість для можливості автозаповнення :високий, середній, низький), 
        //по замовчуванню - середній
        //	- кнопку Додати, що додає відповідну подію у  статичний текст(чи ListBox: listbox1.Items.Add() - доповнення списку listbox1)
        //	- кнопку очищення списку подій
        //	- кнопку збереження плану подій у текстовому(xml чи json) файлі(з назвою, що містить поточну дату).
        //Зауваження.Не дозволяти планування на "вчора"
        //При розв"язуванні задачі визначити клас Подія(Event) з полями назва, дата-час, пріоритет, місце події.
        //Визначити також клас для серіалізації(десеріалізації) списку подій.

        EventList eventList = new EventList();

        public TaskManager()
        {
            InitializeComponent();
        }
        private void btnClaer_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void btnAdd_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            Event eve = new Event
            {
                EventText = textTask.Text,
                Plases = textEvent.Text,
                date = dateTimePicker1.Value,
                Priority = textPriority.Text
            };
            eventList.AddEvent(eve);
            eventList.SaveToXml(dateTimePicker1.Value);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool enterFull = true;
            foreach (Control control in Controls)
                if (control is TextBox)
                {
                    if (control.Text == "")
                    {
                        enterFull = false;
                        MessageBox.Show("Enter all of them");
                        break;
                    }
                }
            if (enterFull == true)
            {
                this.listBox.Items.Add(textTask.Text);
                this.listBox.Items.Add(textEvent.Text);
                this.listBox.Items.Add(dateTimePicker1.Text);
                this.listBox.Items.Add(textPriority.Text);
            }
        }
        
    }
}
