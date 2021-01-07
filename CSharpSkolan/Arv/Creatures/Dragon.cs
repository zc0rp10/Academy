using System;
using System.Collections.Generic;
using System.Text;

namespace Creatures
{
    class Dragon : Creature
    {
        protected string Color;

        public Dragon(string name, string color) : base(name)
        {
            Color = color;
        }

        public void Attack()
        {
            Console.WriteLine($"{Color} dragon attacks with fire breath.");
        }
    }
}
