using System.Collections.Generic;

namespace EXAM
{
    public class Test
    {
        public string Question { get; set; }
        public int trueCount { get; set; }
        public List<string> Answers { get; set; } = new List<string>();
        public List<bool> Сorrectness { get; set; } = new List<bool>();
    }
}
