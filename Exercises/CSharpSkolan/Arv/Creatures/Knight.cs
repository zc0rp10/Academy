using System;
using System.Collections.Generic;
using System.Text;

namespace Creatures
{
    class Knight : Creature
    {
        protected string Weapon;

        public Knight(string name, string weapon) : base(name)
        {
            Weapon = weapon;
        }

        public void Attack()
        {
            Console.WriteLine($"Knight {Name} attacks with a {Weapon}.");
        }
    }
}
