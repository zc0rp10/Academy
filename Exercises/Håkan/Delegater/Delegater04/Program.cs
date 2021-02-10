using System;

namespace Delegater04
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeMethod("Academy", Decision);
        }

        static bool Decision()
        {
            Console.Write("Stora eller små bokstäver?: ");
            string input = Console.ReadLine();
            return input.ToLower() == "stora";
        }

        static void SomeMethod(string s, Func<bool> f)
        {
            if (f())
                Console.WriteLine(s.ToUpper());
            else
                Console.WriteLine(s.ToLower());
        }
    }
}
