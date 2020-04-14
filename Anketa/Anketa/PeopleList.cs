﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Anketa
{
    [Serializable]

    public class PeopleList
    {
        public List<People> peoples { get; set; } = new List<People>();

        public PeopleList()
        {
        }

        public void AddStud(People e)
        {
            peoples.Add(e);
        }

        public void SaveToXml()
        {
            string file = "People" + ".xml";
            XmlSerializer xml = new XmlSerializer(peoples.GetType());
            using (Stream stream = new FileStream(file, FileMode.Create, FileAccess.Write))
            {
                xml.Serialize(stream, peoples);
            }
            MessageBox.Show("Completed!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        public void Load()
        {

            XmlSerializer xml = new XmlSerializer(peoples.GetType());
            string file = "People" + ".xml";
            using (Stream stream = new FileStream(file, FileMode.Open, FileAccess.Read))
            {
                peoples = (List<People>)xml.Deserialize(stream);
            }
        }
    }
}
