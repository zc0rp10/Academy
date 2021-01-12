using System;

namespace NestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    char x = (i % 2 == 0 && j% 2 == 0 || i % 2 != 0 && j % 2 != 0) ? 'o' : '#';
                    Console.Write(x);
                }
                Console.WriteLine();
            }
        }
    }
}

