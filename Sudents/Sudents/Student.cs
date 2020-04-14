using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudents
{
    [Serializable]
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime date { get; set; }
        public string Genger { get; set; }
        public string Hobby { get; set; }

        public Student()
        {

        }
    }
}
