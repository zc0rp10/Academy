using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    abstract class Monster : Character
    {
        protected Monster(string name, int health, int strength) : base(name, health, strength)
        {

        }
    }
}
