using System;
using System.Collections.Generic;
using System.Text;

namespace NotAnotherOtherRPG
{
    class Being
    {
        public Being(string name, int hp, int strength, int agility, int speed)
        {
            Name = name;
            HP = hp;
            Strength = strength;
            Agility = agility;
            Speed = speed;
        }

        public string Name { get; set; }
        public int HP { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Speed { get; set; }
    }
}
