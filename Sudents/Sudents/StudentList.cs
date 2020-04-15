using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Sudents
{
    [Serializable]

    public class StudentList
    {
        public List<Student> Stud { get; set; } = new List<Student>();

        public StudentList()
        {
        }

        public void AddStud(Student e)
        {
            Stud.Add(e);
        }

        public void SaveToXml()
        {
            string file = "Students" + ".xml";
            XmlSerializer xml = new XmlSerializer(Stud.GetType());
            using (Stream stream = new FileStream(file, FileMode.Create, FileAccess.Write))
            {
                xml.Serialize(stream, Stud);
            }
            MessageBox.Show("Completed!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        public void Load()
        {

            XmlSerializer xml = new XmlSerializer(Stud.GetType());
            string file = "Students" + ".xml";
            using (Stream stream = new FileStream(file, FileMode.Open, FileAccess.Read))
            {
                Stud = (List<Student>)xml.Deserialize(stream);
            }
        }
    }
}
