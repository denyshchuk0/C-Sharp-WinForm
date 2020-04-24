using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anketa
{
    [Serializable]
    public class People
    {
        public string Name { get; set; }
        public string Genger { get; set; }
        public DateTime date { get; set; }
        public List<string> Lang { get; set; }

        public People()
        {

        }
        public override string ToString()
        {
            return $"{Genger} {date} {Lang}";

        }
    }
}
