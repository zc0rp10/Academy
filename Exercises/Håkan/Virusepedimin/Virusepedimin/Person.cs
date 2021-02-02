using System;
using System.Collections.Generic;
using System.Text;

namespace Virusepedimin
{
    class Person
    {
        public bool Infected;
        public bool Immune;
        public int InfectedWhen;

        public Person(bool infected, bool immune)
        {
            Infected = infected;
            Immune = immune;
            InfectedWhen = -1;
        }

        public Person(bool infected, bool immune, int infectedWhen)
        {
            Infected = infected;
            Immune = immune;
            InfectedWhen = infectedWhen;
        }
    }
}
