using System;

namespace _1_TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skapa en Console Application som hanterar fel inmatning i förra övningen, Ovning4.pd
            EttTillHundra();
        }

        private static void EttTillHundra()
        {
            try
            {
                Console.Write("Skriv in ett heltal mellan 1 och 100: ");
                int num = int.Parse(Console.ReadLine());
                if (num > 0 && num <= 100)
                {
                    while (num < 101)
                    {
                        Console.WriteLine(num++);
                    }
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("ERROR: Maxvärde på talet överskridet.");
            }
            catch (FormatException)
            {
                Console.WriteLine("ERROR: Felaktigt format på det inmata värdet. Sannorlikt angav du inget värde " +
                    "eller så var värdet inte ett heltal.");
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e.Message);
            }
        }
    }
}
