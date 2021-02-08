using System;

namespace Delegater02
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string, bool> p = PrintIt;
            p("My string to print", false);
            p("My string to print", true);
        }

        static void PrintIt(string value, bool toUpper)
        {
            if (toUpper)
                value = value.ToUpper();

            Console.WriteLine(value);
        }
    }
}
