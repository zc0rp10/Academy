using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLibrary
{
    public abstract class Item
    {
        public Item(int potency, double value)
        {
            Potency = potency;
            Value = value;
        }

        public int Potency { get; set; }
        public double Value { get; set; }

        public abstract void AffectPlayer(Player player);
    }
}
