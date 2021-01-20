using bflibcs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bankomat
{
    class Konto
    {
        // Queue
        public decimal balance;
        public Queue<decimal> history;

        public Konto()
        {
            balance = 0;
            history = new Queue<decimal>();
        }

        public void Deposit()
        {
            decimal value = ConsoleExt.GetDecimal("How much would you like to deposit: ");
            balance += value;
            history.Enqueue(value);

            if (history.Count == 11)
                history.Dequeue();
        }

        public void Withdraw()
        {
            decimal value = ConsoleExt.GetDecimal("How much would you like to deposit: ");
            balance -= value;
            history.Enqueue(value - (value * 2));

            if (history.Count == 11)
                history.Dequeue();
        }

        public void PrintHistory()
        {
            Console.Clear();
            Console.WriteLine("   Swedbank ATM   ");
            Console.WriteLine("------------------");
            Console.WriteLine($"Current Balance: {balance} kr");
            Console.WriteLine();
            Console.WriteLine("Transaction History");
            foreach (var item in history.Reverse())
            {
                Console.WriteLine(item + " kr");
            }
            Console.ReadKey();
        }
    }
}
