using System;
using bflibcs;

namespace _2_OneToHundred
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skapa en Console Application där användaren får mata in ett tal mellan 1 och 100. Programmet skriver sedan ut alla tal 
            // utifrån angivet tal upp till 100. Om tal utanför 1 till 100 matas in, avslutas programmet.
            EttTillHundra();
            //EttTillHundraExtra();
        }

        private static void EttTillHundra()
        {
            double num = ConsoleExt.GetNumber("Skriv in ett tal mellan 1 och 100: ");
            if (num > 0 && num <= 100)
            {
                while (num < 101)
                {
                    Console.WriteLine(num++);
                }
            }
        }

        // Extra, samma som punkt 1 och 2 ovan med en ”do { ... } while( <villkor> )”loopistället.
        private static void EttTillHundraExtra()
        {
            double num = ConsoleExt.GetNumber("Skriv in ett tal mellan 1 och 100: ");


            if (num > 0 && num <= 100)
            {
                do
                {
                    Console.WriteLine(num++);
                } while (num < 101);
            }
        }
    }
}
