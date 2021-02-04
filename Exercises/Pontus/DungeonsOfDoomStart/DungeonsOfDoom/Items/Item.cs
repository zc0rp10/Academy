using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    abstract class Item
    {
        protected Item(string name, int value = 0)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; set; }
        public int Value { get; set; }

        public abstract void AffectPlayer(Player player);

    }
}
