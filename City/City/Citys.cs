using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace City
{
    public partial class Citys : Form
    {
        List<ClassCity> listCities = new List<ClassCity>();

        public Citys()
        {
            InitializeComponent();

            listCities.Add(new ClassCity()
            {
                Name = "Kiev",
                Url = "https://uk.wikipedia.org/wiki/%D0%9A%D0%B8%D1%97%D0%B2",
                IL = iLKiev
            });
            listCities.Add(new ClassCity()
            {
                Name = "Zmerenka",
                Url = "https://uk.wikipedia.org/wiki/%D0%96%D0%BC%D0%B5%D1%80%D0%B8%D0%BD%D0%BA%D0%B0",
                IL = iLZmerenka
            });
            listCities.Add(new ClassCity()
            {
                Name = "Odessa",
                Url = "https://uk.wikipedia.org/wiki/%D0%9E%D0%B4%D0%B5%D1%81%D0%B0",
                IL = iLOdesa
            });
            listCities.Add(new ClassCity()
            {
                Name = "Lviv",
                Url = "https://uk.wikipedia.org/wiki/%D0%9B%D1%8C%D0%B2%D1%96%D0%B2",
                IL = iLLviv
            });
            
            //initial values
            ShowCity(listCities[0]);
            cbCitys.SelectedIndex = 0;
        }
        private void ShowCity(ClassCity item)
        {
            hScrollBar.Maximum = item.IL.Images.Count - 1; 
            hScrollBar.LargeChange = hScrollBar.SmallChange = 1;
            pictureBox.Image = item.IL.Images[hScrollBar.Value];
            this.Text = item.Name + ": views "+ item.View.ToString();
        }

        private void ChoiseCity()
        {
            for (int i = 0; i < cbCitys.Items.Count; i++)
            {
                if (cbCitys.SelectedIndex == i)
                {
                    ShowCity(listCities[i]);
                    listCities[i].View++;
                }
            }
        }
        private void hScrollBar_ValueChanged(object sender, EventArgs e)
        {
            ChoiseCity();
        }

        private void cbCitys_SelectedIndexChanged(object sender, EventArgs e)
        {
            hScrollBar.Value = 0; //start position for change city
            ChoiseCity();
            linkLabel.Text = "Wiki: " + listCities[cbCitys.SelectedIndex].Name;
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(listCities[cbCitys.SelectedIndex].Url);//show web
        }
    }
}
