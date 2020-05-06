using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneDirectory
{
    public class PeopleList
    {
        public List<People> listPeoples { get; set; } = new List<People>();
        public void Add(People p)
        { 
            listPeoples.Add(p);
        }
    }

}
