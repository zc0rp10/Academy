using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    class Player : Character
    {
        public Player(int health, int magic, int strength, int x, int y) : base(health, strength)
        {
            Health = health;
            Magic = magic;
            X = x;
            Y = y;
            Backpack = new List<Item>();
        }

        public int X { get; set; }
        public int Y { get; set; }

        public int Magic { get; set; }

        public List<Item> Backpack { get; set; }
    }
}
