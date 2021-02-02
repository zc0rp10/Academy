using System;
using bflibcs;

namespace Övning_6___Tillägg
{
    class Program
    {
        
        static string[] transactions = new string[10];
        static int totalTransacations = 0;

        static void Main(string[] args)
        {
            bool quit = false;
            decimal balance = 0;
            while (!quit)
            {
                DrawUI(balance);

                var keyInfo = ListenForKeyPress();
                switch (keyInfo.Key)
                {
                    case ConsoleKey.I: { Console.Beep(); balance = Deposit(balance); break; }
                    case ConsoleKey.U: { Console.Beep(); balance = Withdraw(balance); break; }
                    case ConsoleKey.S: { Console.Beep(); ShowSaldo(balance); break; }
                    case ConsoleKey.T: { Console.Beep(); ShowTransactions(balance); break; }
                    case ConsoleKey.A: { Console.Beep(); quit = true; break; }
                    default: break;
                }


            };
        }

        private static void ShowSaldo(decimal balance)
        {
            Console.Clear();
            Console.WriteLine("   Swedbank ATM   ");
            Console.WriteLine("------------------");
            Console.WriteLine($"Account Balance: {balance}");
            Console.ReadKey(true);
        }

        private static void ShowTransactions(decimal balance)
        {
            Console.Clear();
            Console.WriteLine("   Swedbank ATM   ");
            Console.WriteLine("------------------");
            Console.WriteLine($"Account Balance: {balance}");

            for (int i = transactions.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(transactions[i]);
            }
            Console.ReadKey(true);
        }

        private static decimal Withdraw(decimal balance)
        {
            Console.Clear();
            Console.WriteLine("   Swedbank ATM   ");
            Console.WriteLine("------------------");
            Console.WriteLine($"Account Balance: {balance}");
            decimal withdraw;
            do
            {
                withdraw = ConsoleExt.GetDecimal("Enter the amount to withdraw: ");
            } while (!CheckNegative(balance, withdraw) && !(withdraw < 0));
            AddTransaction($"{DateTime.Now}: -{withdraw:f2} kr.");
            totalTransacations++;
            return balance -= withdraw;
        }

        private static bool CheckNegative(decimal balance, decimal withdraw)
        {
            if (balance - withdraw < 0)
                return false;
            else
                return true;
        }

        private static decimal Deposit(decimal balance)
        {
            Console.Clear();
            Console.WriteLine("   Swedbank ATM   ");
            Console.WriteLine("------------------");
            Console.WriteLine($"Account Balance: {balance}");
            decimal deposit;
            do
            {
                deposit = ConsoleExt.GetDecimal("Enter the amount to deposit: ");
            } while (deposit < 0);
            AddTransaction($"{DateTime.Now}: {deposit:f2} kr.");
            
            totalTransacations++;
            return balance += deposit;
        }

        private static void AddTransaction(string value)
        {
            transactions[totalTransacations % transactions.Length] = value;
        }

        private static void DrawUI(decimal balance)
        {
            Console.Clear();
            Console.WriteLine("   Swedbank ATM   ");
            Console.WriteLine("------------------");
            Console.WriteLine($"Account Balance: {balance}");
            Console.WriteLine();
            Console.WriteLine("[I]nsättning");
            Console.WriteLine("[U]ttag");
            Console.WriteLine("[S]aldo");
            Console.WriteLine("[T]ransaction History");
            Console.WriteLine("[A]vsluta");
            Console.WriteLine();
            Console.WriteLine("Choose one of the above options..");
        }

        private static ConsoleKeyInfo ListenForKeyPress()
        {
            {
                ConsoleKeyInfo keyInfo;
                keyInfo = Console.ReadKey(true);

                return keyInfo;
            }
        }
    }
}
