using System;

namespace Inmatning
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = GetValidNum();
            Console.WriteLine(number);
        }

        private static int GetValidNum()
        {
            bool isValid;
            int number;
            string msg = "Enter a number: ";

            do
            {
                Console.Write(msg);
                msg = "Not an integer, please try again: ";
                string input = Console.ReadLine();
                isValid = int.TryParse(input, out number);
            } while (!isValid);

            return number;
        }
    }
}
