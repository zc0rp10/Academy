using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a floating point number: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine($"Result: {RoundToNearestInt(num1)}");
        }

        static int RoundToNearestInt(float num1)
        {
            return (int)Math.Round(num1, MidpointRounding.AwayFromZero);
        }
    }
}

