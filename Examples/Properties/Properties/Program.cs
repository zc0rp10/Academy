using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(30, "Sture");

            person.Age = 5;
            person.Age = -10;

            Console.WriteLine(person.Age);
            Console.WriteLine(person.Age);
        }
    }
}
