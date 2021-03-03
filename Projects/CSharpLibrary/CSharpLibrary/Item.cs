using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLibrary
{
    public abstract class Item
    {
        public Item(string name, double value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; set; }
        public double Value { get; set; }
        public abstract void AffectPlayer(Player player);
    }
}
