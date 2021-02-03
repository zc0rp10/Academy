using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    abstract class Animal : IEatable
    {
        public double Weight { get; set; }

        public Animal(double weight)
        {
            Weight = weight;
        }

        public virtual void Eat(IEatable food)
        {
            Weight += food.Weight;
        }

        public override string ToString()
        {
            return $"Weight: {Weight}";
        }
    }
}
