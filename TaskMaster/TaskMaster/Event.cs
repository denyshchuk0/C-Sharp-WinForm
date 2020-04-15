using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMaster
{
    [Serializable]
    public class Event
    {
        public string EventText {get; set;}
        public string Plases { get; set; }
        public DateTime date { get; set; }
        public string Priority { get; set; }
        public Event()
        {
        }
    }
}

