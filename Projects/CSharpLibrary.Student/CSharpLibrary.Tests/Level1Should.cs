using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace CSharpLibrary.Tests
{
    public class Level1Should
    {
        [Fact]
        public void CreatePlayer()
        {
            // Create a Player Class with a constructor
            var player = new Player("Sven", 200, 100);
            string result = player.PlayerDescription();
            Assert.Equal("Sven has 200 HP and 100 MP.", result);
        }

        [Fact]
        public void CreateEnemy()
        {
            // Create Enemy Class with constructor
            var enemy = new Enemy(100);
            int result = enemy.Health;
            Assert.Equal(100, result);
        }

        [Fact]
        public void CreatePotions()
        {
            // Create an Item Class and Potion Class. Potion Class should INHERIT from Item Class.
            var firstPotion = new Potion(10, 50);
            var secondPotion = new Potion(10, 50);

            Assert.True(firstPotion.Potency.GetType() == typeof(int));
            Assert.True(secondPotion.Value.GetType() == typeof(double));
        }

        [Fact]
        public void CreatePotionsWithTypes()
        {
            // Create a new file and define an enum for PotionType
            var firstPotion = new Potion(10, 50, PotionType.Health);
            var secondPotion = new Potion(10, 50, PotionType.Damage);

            Assert.True(firstPotion.PotionType == PotionType.Health);
            Assert.True(secondPotion.PotionType == PotionType.Damage);
        }

        [Fact]
        public void AddPotionsToPlayerInventory()
        {
            var player = new Player("Sven", 200, 100);
            var firstPotion = new Potion(10, 50, PotionType.Health);
            var secondPotion = new Potion(10, 50, PotionType.Damage);

            // Implement the Inventory property on Player Class
            player.Inventory.Add(firstPotion);
            player.Inventory.Add(secondPotion);
        }

        [Fact]
        public void GetInventoryValue()
        {
            // Need to implement a Linq metod..
            var player = new Player("Sven", 200, 100);
            var firstPotion = new Potion(10, 50, PotionType.Health);
            var secondPotion = new Potion(10, 50, PotionType.Damage);
            player.Inventory.Add(firstPotion);
            player.Inventory.Add(secondPotion);

            // Using LINQ - Add a method to the player class that returns the total value of the inventory.
            var result = player.TotalInventoryValue();

            Assert.Equal(20, result);
        }

        [Fact]
        public void AddSpellsToSpellBook()
        {
            var player = new Player("Sven", 200, 100);
            var fireI  = new Spell("Fire I", 10, MagicType.Fire);

            // Implement the SpellBook property on Player Class
            player.SpellBook.Add(fireI);
        }

        [Fact]
        public void GetListOfAllFireSpellsInSpellBook()
        {
            var player = new Player("Sven", 200, 100);

            player.SpellBook = new List<Spell> {
                new Spell("Fire I", 10, MagicType.Fire),
                new Spell("Fire II", 20, MagicType.Fire),
                new Spell("Fire III", 30, MagicType.Fire),
                new Spell("Ice I", 10, MagicType.Ice),
                new Spell("Ice II", 20, MagicType.Ice),
                new Spell("Ice III", 30, MagicType.Ice),
            };

            // Using Linq - Complete the below line to return a list of Fire Spells in the players Spellbook.
            var fireSpells = player.SpellBook.Where(s => s.MagicType == MagicType.Fire).ToList();

            Assert.IsType<List<Spell>>(fireSpells);
            Assert.Equal(3, fireSpells.Count);
        }

        [Fact]
        public void PlayerUsePotion()
        {
            var player = new Player("Sven", 200, 100);
            var firstPotion = new Potion(10, 50, PotionType.Health);

            // Implement the AffectPlayer method on Item Class
            firstPotion.AffectPlayer(player);

            Assert.Equal(250, player.Health);
        }

        [Fact]
        public void PlayerAttacksEnemy()
        {
            // Tip: The 4th constructor argument you can implement as an int property called Damage.
            var player = new Player("Sven", 200, 100, 10);
            var enemy = new Enemy(100);

            // Implement the Attack Metod on Player Class
            player.Attack(enemy);

            Assert.Equal(90, enemy.Health);
        }
    }
}
