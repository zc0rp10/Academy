using System;
using System.Collections.Generic;
using System.Text;

namespace Creatures
{
    class Creature
    {
        public int Health;
        public int Shield;
        protected string Name;

        public Creature(string name)
        {
            Name = name;
        }

        public string GetInfo()
        {
            return $"Name: {Name}, Health: {Health}, Shield: {Shield}";
        }
    }
}
