using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace millioner
{
    class Question
    {
        string text;
        public bool reply;
        public Question(string text)
        {
            this.text = text;
        }

        public override string ToString()
        {
            return $"{text}";
        }

    }
}
