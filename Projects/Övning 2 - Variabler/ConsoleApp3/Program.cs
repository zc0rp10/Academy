using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console Calculator");
            Console.WriteLine("------------------");

            Console.WriteLine("Enter a number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a second number: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a third number: ");
            double num3 = double.Parse(Console.ReadLine());
            
            Console.WriteLine($"Result: {CalculateAddition(num1, num2, num3)}, Mean Value: {CalculateMean(num1, num2, num3)}");
        }

        static double CalculateAddition(double num1, double num2, double num3)
        {
            return num1 + num2 + num3;
        }

        static double CalculateMean(double num1, double num2, double num3)
        {
            return (num1 + num2 + num3) / 3;
        }
    }
}
