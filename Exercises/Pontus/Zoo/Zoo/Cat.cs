using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Cat : Animal
    {
        public Cat() : base(4.50)
        {
        }

        public override string ToString()
        {
            return $"Cat ({base.ToString()})";
        }
    }
}
