using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    class AbstractClass : Monster
    {
        public AbstractClass(int health, int strength) : base("Abstract Class", health, strength)
        {

        }

        override public int Attack(Character opponent)
        {
            if (Health < opponent.Health / 10)
                return base.Attack(opponent) / 4;
            else
                return base.Attack(opponent) / 2;
        }
    }

}
