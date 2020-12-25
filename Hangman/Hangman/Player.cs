using System;
using System.Collections.Generic;
using System.Text;

namespace Hangman
{
    class Player
    {
        public string name;
        public List<char> guessedLetters = new List<char>();
        public int score;

        public Player(string name)
        {
            this.name = name;
            score = 0;
        }
    }
}
