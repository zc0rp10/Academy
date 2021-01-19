using System;

namespace Extra1
{
    class Program
    {
        static void Main(string[] args)
        {
            SolutionOne();
            SolutionTwo();
        }

        private static void SolutionOne()
        {
            int a = 1;
            int b = 2;
            float c = (float)a / b;
            Console.WriteLine(c);
        }

        private static void SolutionTwo()
        {
            float a = 1;
            float b = 2;
            float c = a / b;
            Console.WriteLine(c);
        }
    }
}
