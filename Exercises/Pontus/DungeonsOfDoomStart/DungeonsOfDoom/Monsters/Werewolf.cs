using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    class Werewolf : Monster
    {
        public bool Enraged { get; set; }
        public Werewolf(int health, int strength, bool enraged) : base("Werewolf", health, strength)
        {
            Enraged = enraged;
            if (enraged)
            {
                Strength = strength * 2;
            }
        }
    }
}
