using DungeonsOfDoom.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    class Sword : Item
    {
        Random random = new Random();

        public Sword(SwordType type) : base($"{type}")
        {
            // TODO: Remove SwordType argument. A random instead to decide
            // type of, every time a new Sword is created.
            Type = type;

            if (type == SwordType.iMacG3)
                Damage = random.Next(5, 11);
            else if (type == SwordType.Commodore64)
                Damage = random.Next(11, 21);
            else if (type == SwordType.GodEaterSword)
                Damage = 9001;
        }

        public int Damage { get; set; }
        public SwordType Type { get; set; }

        public override void AffectPlayer(Player player)
        {
            player.Strength += Damage;
        }
    }
}
