using DungeonsOfDoom.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    class Potion : Item
    {
        public Potion(/*PotionType type*/) : base(/*$"{type} */"Health Potion")
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

    class Poison : Item
    {
        public Poison() : base("Poison Potion")
        {
            Potency = 100;
        }
        public int Potency { get; set; }
        public override void AffectPlayer(Player player)
        {
            player.Health -= Potency; ;
        }
    }
}
