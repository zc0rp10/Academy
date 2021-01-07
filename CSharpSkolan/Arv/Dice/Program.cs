using System;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Dice diceOne = new Dice(6);
            Dice diceTwo = new Dice(20);

            Console.WriteLine(diceOne.Throw());
            Console.WriteLine(diceTwo.Throw());
        }
    }
}
