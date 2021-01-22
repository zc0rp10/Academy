using System;
using System.Collections.Generic;
using System.Text;

namespace NotAnotherOtherRPG
{
    class Player : Being
    {
        public CharacterClass CharacterClass { get; set; }

        public Player(string name, int hp, int strength, int agility, int speed, CharacterClass characterClass) : base(name, hp, strength, agility, speed)
        {
            CharacterClass = characterClass;
        }

    }

    public enum CharacterClass
    {
        Fighter,
        Thief,
        Mage,
    }
}
