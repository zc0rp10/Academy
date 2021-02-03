using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    abstract class Character
    {
        Random random = new Random();
        public Character(string name, int health, int strength)
        {
            Name = name;
            Health = health;
            Strength = strength;
        }

        public int Health { get; set; }
        public int Strength { get; set; }
        public string Name { get; set; }

        public virtual int Attack(Character character)
        {
            // TODO : Add Random to damage. 90-110%.
            int multiplier = random.Next(-10, 11);
            return Strength + multiplier;
        }

        public virtual int TakeDamage(int damage)
        {
            Health = Health - damage;
            return damage;
        }
    }
}
