using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalLibrary
{
    public class Hamster
    {
        public Hamster(string name, bool isPet, HamsterSpecie specie)
        {
            Name = name;
            IsPet = isPet;
            Specie = specie;
        }

        public string Name { get; set; }
        public bool IsPet { get; set; }
        public HamsterSpecie Specie { get; set; }

        public string Greet()
        {
            return $"{Name} is a {(IsPet == true ? "pet" : "wild")} {Specie} hamster.";
        }
    }
}
