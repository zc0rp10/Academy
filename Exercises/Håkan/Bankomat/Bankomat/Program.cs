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
            Konto konto = new Konto();
            while (!quit)
            {
                DrawUI();
                ListenForKeyPress(konto);
               
            };
        }

        private static void DrawUI()
        {
            Console.Clear();
            Console.WriteLine("   Swedbank ATM   ");
            Console.WriteLine("------------------");
            Console.WriteLine();
            Console.WriteLine("[I]nsättning");
            Console.WriteLine("[U]ttag");
            Console.WriteLine("[S]aldo");
            Console.WriteLine("[A]vsluta");
            Console.WriteLine();
            Console.WriteLine("Choose one of the above options..");
        }

        private static void ListenForKeyPress(Konto konto)
        {
            {
                ConsoleKeyInfo keyInfo;
                keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.I: { Console.Beep(); konto.Deposit(); ; break; }
                    case ConsoleKey.U: { Console.Beep(); konto.Withdraw(); ; break; }
                    case ConsoleKey.S: { Console.Beep(); konto.PrintHistory(); break; }
                    case ConsoleKey.A: { Program.quit = true; break; }
                    default: break;
                }
            }
        }
    }
}
