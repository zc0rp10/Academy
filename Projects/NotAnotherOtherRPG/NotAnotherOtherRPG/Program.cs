using System;

namespace NotAnotherOtherRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            GameManager gameManager = new GameManager();
            Player player = new Player("Bertil", 200, 10, 10, 10, CharacterClass.Fighter);
        }

        


    }
}
