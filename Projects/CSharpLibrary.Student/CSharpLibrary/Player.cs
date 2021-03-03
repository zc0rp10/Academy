using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpLibrary
{
    public class Player
    {
        public Player(string name, int health, int mana)
        {
            Name = name;
            Health = health;
            Mana = mana;
            Inventory = new List<Item>();
            SpellBook = new List<Spell>();
        }

        public Player(string name, int health, int mana, int damage)
        {
            Name = name;
            Health = health;
            Mana = mana;
            Inventory = new List<Item>();
            SpellBook = new List<Spell>();
            Damage = damage;
        }
        public int Damage { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }

        public List<Item> Inventory { get; set; }

        public string PlayerDescription()
        {
            return $"{Name} has {Health} HP and {Mana} MP.";
        }

        public double TotalInventoryValue()
        {
            return Inventory.Sum(i => i.Value);
        }

        public List<Spell> SpellBook { get; set; }

        public void Attack(Enemy enemy)
        {
            enemy.Health -= Damage;
        }
    }
}
