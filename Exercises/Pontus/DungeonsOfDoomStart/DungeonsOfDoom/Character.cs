using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsOfDoom
{
    abstract class Character
    {
        public Character(int health, int strength)
        {
            Health = health;
            Strength = strength;
        }

        public int Health { get; set; }
        public int Strength { get; set; }
        
       public virtual int Attack()
        {

            return Strength;

        }

        public virtual void TakeDamage(int damage)
        {
            Health = Health - damage;

        }
    }
}
