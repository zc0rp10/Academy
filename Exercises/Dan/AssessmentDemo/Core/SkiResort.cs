using System;
using System.Collections.Generic;

namespace Assessment.Core
{
    public class SkiResort
    {
        public SkiResort(string name, int numberOfLifts)
        {
            Name = name;
            NumberOfLifts = numberOfLifts;
        }

        public string Name { get; set; }
        public int NumberOfLifts { get; set; }
    }
}
