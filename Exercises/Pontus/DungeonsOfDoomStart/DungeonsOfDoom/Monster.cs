using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    abstract class Monster : Character
    {
        protected Monster(int health, int strength, string name) : base(health, strength)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
