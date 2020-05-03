using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace UnitForGame
{
    public partial class UnitsForm : Form
    {
        List<Unit> units = new List<Unit>();
        List<Unit> white = new List<Unit>();
        string nameWhite = "White";
        List<Unit> black = new List<Unit>();
        string nameBlack = "Black";

        public UnitsForm()
        {
            InitializeComponent();
            units.Add(new Soldier());
            units.Add(new Archer());
            units.Add(new Wizard());
            lbUnits.DataSource = units;
            lbUnits.ValueMember = "UnitName";
        }
        private void RefreshDataBase(ListBox lbTeams, List<Unit> unit)
        {
            lbTeams.DataSource = null;
            lbTeams.DataSource = unit;
            lbTeams.DisplayMember = "UnitName";
            
        }

        private void AddUnit(ListBox lbTeams, List<Unit> unit)
        {
            
            if (unit.Count == nupUnitsCount.Value)
                return;
            nupUnitsCount.Minimum = lbTeams.Items.Count;
            foreach (Unit u in units)
            {
                if (lbUnits.SelectedItem == u)
                {
                    unit.Add(u);
                }
            }
            RefreshDataBase(lbTeams, unit);
            dudTeam_TextChanged(null, null);
        }
        private void PopUnit(ListBox lbTeams, List<Unit> unit)
        {
           
            if (lbTeams.Items.Count == 0)
            {
                MessageBox.Show("Team is null!", "NULL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            nupUnitsCount.Minimum = lbTeams.Items.Count-1;
            unit.RemoveAt(lbTeams.Items.Count - 1);
            RefreshDataBase(lbTeams, unit);
        }

        private void Save(string name, List<Unit> team)
        {
            string file = name + " team" + ".xml";
            XmlSerializer xml = new XmlSerializer(team.GetType());
            using (Stream stream = new FileStream(file, FileMode.Create, FileAccess.Write))
            {
                xml.Serialize(stream, team);
            }
            MessageBox.Show($"Save {name} complite!!!", "NULL", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnAddWhite_Click(object sender, EventArgs e)
        {
            AddUnit(lbWhite, white);
        }

        private void btnPopWhite_Click(object sender, EventArgs e)
        {
            PopUnit(lbWhite, white);
        }

        private void btnAddBlack_Click(object sender, EventArgs e)
        {
            AddUnit(lbBlack, black);
        }

        private void btnPopBlack_Click(object sender, EventArgs e)
        {
            PopUnit(lbBlack, black);
        }

        private void btnSaveWhite_Click(object sender, EventArgs e)
        {
            Save(nameWhite, white);
        }

        private void btnSaveBlack_Click(object sender, EventArgs e)
        {
            Save(nameBlack, black);
        }
        private void dudTeam_TextChanged(object sender, EventArgs e)
        {
            if (dudTeam.Text == nameWhite)
            {
                RefreshDataBase(lbTeams, white);
                lbTeams.Refresh();
                pictureBox.Image = Image.FromFile("../../img/White.png");

            }
            else if (dudTeam.Text == nameBlack)
            {
                RefreshDataBase(lbTeams, black);
                lbTeams.Refresh();
                pictureBox.Image = Image.FromFile("../../img/Black.png");
            }
        }
    }
}
