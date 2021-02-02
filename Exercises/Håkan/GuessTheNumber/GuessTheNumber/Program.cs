using System;
using bflibcs;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Think of a secret number between 1 and 1000. Then press any key to continue...");
            Console.ReadKey(true);

            Console.WriteLine("I will guess your secret number in no more than ten atempts as long as you truthfully" +
                " tell me if my guess is higher or lower then the number you are thinking of.");

            int min = 0;
            int max = 1001;
            bool victory = false;
            bool isSolved = false;
            int nbrOfGuesses = 0;

            while (!victory)
            {
                int mid = (min + max) / 2;
                if (min + 1 == mid && max - 1 == mid)
                    isSolved = true;
                Console.Clear();
                Console.WriteLine($"I think the number you're thinking of is {mid}.");
                nbrOfGuesses++;
                Console.WriteLine("Did I guess correctly? If not, tell me if your number is [H]igher or [L]ower than my guess. If I'm right, press [R].");
                Console.WriteLine($"I have guessed {nbrOfGuesses} times so far.");

                bool isValid = false;
                do
                {
                    var cki = new ConsoleKeyInfo();
                    cki = Console.ReadKey(true);

                    if (isSolved == true && cki.Key != ConsoleKey.R)
                    {
                        Console.WriteLine("LIAR!!! I've solved it, and I know you're trying to lie!");
                        victory = true;
                    }

                    switch (cki.Key)
                    {
                        case ConsoleKey.H:
                            {
                                isValid = true;
                                min = mid;
                            }
                            break;
                        case ConsoleKey.L:
                            {
                                isValid = true;
                                max = mid;
                            }
                            break;
                        case ConsoleKey.R: { Console.WriteLine("Victory! Could you try a little harder next time please..?"); victory = true; } break;
                        default: { isValid = false; } break;
                    }
                } while (!isValid);
            }
        }
    }
}
