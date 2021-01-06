using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(Divide(10, 0));
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid Argument...");
            }
            catch (Exception)
            {
                Console.WriteLine("Oops, something went wrong...");
            }
        }

        static int Divide(int a, int b)
        {
            if (b == 0)
                throw new ArgumentException("Argument must not be zero.", nameof(b));
            else if
                (a == 0)
                throw new ArgumentException("Argument must not be zero.", nameof(a));

            return a / b;
        }
    }
}
