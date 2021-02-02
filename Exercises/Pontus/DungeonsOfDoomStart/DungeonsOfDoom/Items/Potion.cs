using DungeonsOfDoom.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    class Potion : Item
    {
        public Potion(PotionType type) : base($"{type} Potion")
        {
            Potency = 100;
            Type = type;

        }
        public int Potency { get; set; }
        public PotionType Type { get; set; }
    }
}
