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

        public override int Attack()
        {
            return base.Attack() / 2;
        }
    }

}
