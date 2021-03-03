using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLibrary
{
    public class Potion : Item
    {
        public Potion(int value, int potency) : base("A Potion", value)
        {
            Potency = potency;
        }

        public Potion(int value, int potency, PotionType potionType) : base($"{potionType} Potion", value)
        {
            Potency = potency;
            PotionType = potionType;
        }
        public PotionType PotionType { get; set; }
        public int Potency { get; set; }

        public override void AffectPlayer(Player player)
        {
            player.Health += Potency;
        }
    }
}
