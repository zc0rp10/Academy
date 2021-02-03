using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    class Skeleton : Monster
    {
        public Skeleton(int health, int strength) : base("Skeleton", health, strength)
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
