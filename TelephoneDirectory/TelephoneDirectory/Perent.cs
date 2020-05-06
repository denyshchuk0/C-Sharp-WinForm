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
    public partial class Perent : Form
    {
       public PeopleList List { get; set; } = new PeopleList();
        public ListBox LB{
            set {
                RefreshLable();
            }
        }
        public Perent()
        {
            InitializeComponent();
        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Child child = new Child();
            DialogResult dr = child.ShowDialog();
            
        }
        public void RefreshLable() {
            lbCatalog.DataSource = null;
            lbCatalog.DataSource = List.listPeoples;
            lbCatalog.ValueMember = "Name";
        }
    }
}
