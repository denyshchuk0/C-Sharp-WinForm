using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelephoneDirectory
{
    public partial class Child : Form
    {
        PeopleList list = new PeopleList();
        People people = new People();
        Perent perent = new Perent();
        public Child()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            people.Name = tbName.Text;
            people.Number = Convert.ToInt32(tbNumber.Text);
            list.Add(people);
        }

        private void Child_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
