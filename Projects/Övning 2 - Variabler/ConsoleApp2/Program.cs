using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console Calculator");
            Console.WriteLine("------------------");

            Console.ReadLine();
            Console.WriteLine("Enter a number: ");
            int num1 = ReadLineToInt();

            Console.WriteLine("Enter a second number: ");
            int num2 = ReadLineToInt();

            Console.WriteLine("Result: " + CalculateAddition(num1, num2));
        }

        static int CalculateAddition(int num1, int num2)
        {
            return num1 + num2;
        }

        static int ReadLineToInt()
        {
            return int.Parse(Console.ReadLine());
        }
        
    }
}
