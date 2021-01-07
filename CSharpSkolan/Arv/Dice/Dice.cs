using System;
using System.Collections.Generic;
using System.Text;

namespace Dice
{
    class Dice
    {
        int sides;

        public Dice(int sides)
        {
            this.sides = sides;
        }

        public int Throw()
        {
            Random random = new Random();
            int result = random.Next(1, sides + 1);
            return result;
        }
    }
}
