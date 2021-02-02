using System;
using System.Collections.Generic;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Cat());
            animals.Add(new Dog(10));


            foreach (var animal in animals)
            {
                var lunch = new Dog(1);
                animal.Eat(lunch);
                Console.WriteLine(animal);
            }
        }
    }
}
