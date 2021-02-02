using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Dog : Animal
    {
        public Dog(double weight) : base(weight)
        {
        }

        public override void Eat(Animal food)
        {
            Weight += food.Weight * 0.8;
        }
        public override string ToString()
        {
            return $"Dog ({base.ToString()})";
        }
    }
}
