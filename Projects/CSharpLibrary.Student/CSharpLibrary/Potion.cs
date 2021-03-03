using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLibrary
{
    public class Potion : Item
    {

        public Potion(double value, int potency) : base(potency, value)
        {
            
        }
        public Potion(double value, int potency, PotionType potionType) : base(potency, value)
        {
            PotionType = potionType;
        }
        public PotionType PotionType { get; set; }

        public override void AffectPlayer(Player player)
        {
            player.Health += Potency;
        }
    }
}
