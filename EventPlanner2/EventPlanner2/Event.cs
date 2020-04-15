using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner2
{ 
   [Serializable]
   public class Event
    {
        public string EventText { get; set; }
        public DateTime Date { get; set; } 
        public string Priority { get; set; }
        public Event()
        {
        }
        public override string ToString()
        {
            return $"Event:{EventText} , Date: {Date}, Priority: {Priority} ";
        }
    }
}
