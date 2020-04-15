using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TaskMaster
{
    [Serializable]
   public class EventList
    {
        public List<Event> events { get; set; } = new List<Event>();

        public EventList()
        {

        }
        public void AddEvent(Event e)
        {
            events.Add(e);
        }

        public void SaveToXml(DateTime date)
        {

            string name = date.Date.ToShortDateString();
            string file = name + ".xml";

            XmlSerializer xml = new XmlSerializer(events.GetType());
            using (Stream stream = new FileStream(file, FileMode.Create, FileAccess.Write))
            {
                xml.Serialize(stream, events);
            }
            MessageBox.Show("Completed!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

    }
}
