using System;

namespace Hangman
{
    class Program
    {
        static string userName;
        static int nbrOfGuesses;
        static string correctWord = "smultron";
        static char[] letters;

        static void Main(string[] args)
        {
            StartGame();
            PlayGame();
            EndGame();
        }

        private static void StartGame()
        {
            letters = new char[correctWord.Length];
            for (int i = 0; i < correctWord.Length; i++)
            {
                letters[i] = '-';
            }
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
            do
            {
                Console.Clear();
                DisplayMaskedWord();
                char gussedLetter = AskForLetter();
                CheckLetter(gussedLetter);
            } while (correctWord != new string(letters));

            Console.Clear();
        }

        private static void CheckLetter(char gussedLetter)
        {
            for (int i = 0; i < correctWord.Length; i++)
            {
                if (gussedLetter == correctWord[i])
                    letters[i] = gussedLetter;
            }
        }

        static void DisplayMaskedWord()
        {
            foreach (char c in letters)
                Console.Write(c);

            Console.WriteLine();
        }

        static char AskForLetter()
        {
            string input;

            do
            {
                Console.WriteLine("Enter exactly one character: ");
                input = Console.ReadLine();
            } while (input.Length != 1);

            nbrOfGuesses++;
            return input[0];
        }

        private static void EndGame()
        {
            Console.WriteLine($"Thank you for playing {userName}. You needed {nbrOfGuesses} guesses.");
        }
    }
}
