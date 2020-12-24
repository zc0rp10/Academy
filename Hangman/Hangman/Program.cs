using System;
using System.Linq;

namespace Hangman
{
    class Program
    {
        static string userName;
        static int nbrOfGuesses;
        static char[] correctWord = { 's', 'm', 'u', 'l', 't', 'r', 'o', 'n' };
        static char[] guessedLetters = { '-', '-', '-', '-', '-', '-', '-', '-' };
        static bool endApp = false;

        static void Main(string[] args)
        {
            StartGame();
            while (!endApp)
            {
                PlayGame();
            }
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
            DisplayMaskedWord();
            AskForLetter();
        }

        static void DisplayMaskedWord()
        {
            foreach (char c in guessedLetters)
            {
                Console.Write(c);
            }
            Console.WriteLine();
        }

        static void AskForLetter()
        {
            string input;

            do
            {
                Console.WriteLine("Enter exactly one character: ");
                input = Console.ReadLine();
            } while (input.Length != 1);

            for (int i = 0; i < correctWord.Length; i++)
            {
                if (char.Parse(input) == correctWord[i])
                {
                    guessedLetters[i] = char.Parse(input);
                }
            }
            nbrOfGuesses++;

            if (guessedLetters.SequenceEqual(correctWord))
            { 
                endApp = true;
            }
        }

        private static void EndGame()
        {
            Console.WriteLine($"Thank you {userName} for playing. You guessed {nbrOfGuesses} times.");
        }
    }
}
