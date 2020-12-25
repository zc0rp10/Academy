using System;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Bo", 30);
            Person person2 = new Person("Li", 40);

            person1.Age = 30;
            person2.Age = 40;

            Console.WriteLine(person1.Name);
            Console.WriteLine(person1.Age);
        }
    }
}
