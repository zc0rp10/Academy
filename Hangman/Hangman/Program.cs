using System;

namespace Hangman
{
    class Program
    {
        static string userName;
        static int nbrOfGuesses;

        static void Main(string[] args)
        {
            StartGame();
            PlayGame();
            EndGame();
        }

        private static void StartGame()
        {
            Console.WriteLine("Start Game");
            AskForUsersName();
        }

        static void AskForUsersName()
        {
            Console.Write("Enter your name: ");
            string input = Console.ReadLine();

            if (input.Length < 2)
            {
                Console.WriteLine("Name needs to be longer then two characters, please try again.");
                AskForUsersName();
            }

            userName = input;
        }

        private static void PlayGame()
        {
            Console.WriteLine("Play Game");
            DisplayMaskedWord();
            AskForLetter();
        }

        static void DisplayMaskedWord()
        {
            Console.WriteLine("Display masked word");
        }
        
        static void AskForLetter()
        {
            Console.WriteLine("Asking for letter");
            nbrOfGuesses++;
        }

        private static void EndGame()
        {
            Console.WriteLine($"Thank you {userName} for playing. You guessed {nbrOfGuesses} times.");

        }
    }
}
