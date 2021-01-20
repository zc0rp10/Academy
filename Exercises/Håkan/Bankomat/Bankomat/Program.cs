using System;

namespace Bankomat
{
    class Program
    {
        /* Skapa en Console Application som:
         * 1.   ...med hjälp av en switch sats skapar en inmatningsmeny för en bankomat.
         *      Alternativen ska vara:
         *      [I]nsättning
         *      [U]ttag
         *      [S]aldo
         *      [A]vsluta
         *      
         *      2.Lägg till kod för att hantera kontot, utgå ifrån ett konto med noll kr.
         *          a.Saldot ska visa senaste 10 kontohändelser */
        static bool quit = false;

        static void Main(string[] args)
        {

            while (!quit)
            {
                DrawUI();
                ListenForKeyPress();
               
            };
        }

        private static void DrawUI()
        {
            Console.Clear();
            Console.WriteLine("Welcome to my ATM");
            Console.WriteLine("-----------------");
            Console.WriteLine();
            Console.WriteLine("[I]nsättning");
            Console.WriteLine("[U]ttag");
            Console.WriteLine("[S]aldo");
            Console.WriteLine("[A]vsluta");
            Console.WriteLine();
            Console.WriteLine("Choose one of the above options..");
        }

        private static void ListenForKeyPress()
        {
            {
                ConsoleKeyInfo keyInfo;
                keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.I: { Console.WriteLine("Insättning"); ; break; }
                    case ConsoleKey.U: { Console.WriteLine("Uttag"); ; break; }
                    case ConsoleKey.S: { Console.WriteLine("Saldo"); break; }
                    case ConsoleKey.A: { Program.quit = true; break; }
                    default: break;
                }
            }
        }
    }
}
