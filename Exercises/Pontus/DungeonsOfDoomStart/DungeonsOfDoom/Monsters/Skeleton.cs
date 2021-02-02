using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    class Skeleton : Monster
    {
        public Skeleton(int health, int strength) : base(health, strength, "Skeleton")
        {

        }

        public override int Attack()
        {
            return base.Attack() / 2;
        }
    }

}
