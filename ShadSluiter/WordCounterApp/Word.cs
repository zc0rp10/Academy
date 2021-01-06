using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounterApp
{
    class Word
    {
        public Word(string value, int frequency)
        {
            Value = value;
            Frequency = frequency;
        }

        public string Value { get; set; }
        public int Frequency { get; set; }


    }
}
