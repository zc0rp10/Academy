using System;

namespace _1_OneToTwenty
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skapa en Console Application som med hjälp av en while loop skriver ut alla tal mellan 1 och 20
            EttTillTjugo();
            //EttTillTjugoExtra();

        }

        private static void EttTillTjugo()
        {
            int i = 1;
            while (i <= 20)
            {
                Console.WriteLine(i++);
            }
        }

        // Extra, samma som punkt 1 och 2 ovan med en ”do { ... } while( <villkor> )”loopistället.
        private static void EttTillTjugoExtra()
        {
            int i = 1;

            do
            {
                Console.WriteLine(i++);
            } while (i <= 20);
        }
    }
}
