using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            var (name, age) = GetPersonInfo();
            System.Console.WriteLine(name);
            System.Console.WriteLine(age);
        }

        static (string, int) GetPersonInfo()
        {
            string name = "Pontus";
            int age = 40;
            return (name, age)
        }
    }
}