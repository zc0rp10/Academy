﻿using System;
using System.Collections.Generic;

namespace Hangman
{
    class Program
    {
        static string correctWord = "smultron";
        static char[] letters;
        static Player player;

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

            player = new Player(input);
        }

        private static void PlayGame()
        {
            do
            {
                Console.Clear();
                DisplayMaskedWord();
                char guessedLetter = AskForLetter();
                CheckLetter(guessedLetter);
            } while (correctWord != new string(letters));

            Console.Clear();
        }

        private static void CheckLetter(char guessedLetter)
        {
            for (int i = 0; i < correctWord.Length; i++)
            {
                if (guessedLetter == correctWord[i])
                {
                    letters[i] = guessedLetter;
                    player.score++;
                }
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

            var letter = input[0];

            if (!player.guessedLetters.Contains(letter))
                player.guessedLetters.Add(letter);

            return input[0];
        }

        private static void EndGame()
        {
            Console.WriteLine($"Thank you for playing {player.name}. You needed {player.guessedLetters.Count} guesses. You score was: {player.score}.");
        }
    }
}
