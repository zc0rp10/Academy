using DungeonsOfDoom.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    class PowerKing : Item
    {
        public PowerKing(/*PotionType type*/) : base(/*$"{type} */"Power King")
        {
            Potency = 100;
           // Type = type;

        }
        public int Potency { get; set; }
        // public PotionType Type { get; set; }

        public override void AffectPlayer(Player player)
        {
            player.Health += Potency;
        }

    }
}
