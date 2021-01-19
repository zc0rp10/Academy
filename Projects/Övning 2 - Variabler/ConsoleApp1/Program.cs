using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isValid = false;
            string name;

            do
            {
                Console.WriteLine("What is you name?");
                name = Console.ReadLine();
                if (name.Length > 0)
                    isValid = true;
            } while (!isValid);

            Console.WriteLine($"Hello! {name}!");
        }
    }
}
