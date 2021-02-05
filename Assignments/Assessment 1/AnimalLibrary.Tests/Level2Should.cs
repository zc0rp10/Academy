using System;
using System.Collections.Generic;
using Xunit;

namespace AnimalLibrary.Tests
{
    public class Level2Should
    {
        [Fact]
        public void CreateAPetHamsterWhoDosntLikeFood()
        {
            var h = new Hamster("Maximilian", true, HamsterSpecie.Campbell);
            string result = h.Description();
            Assert.Equal("Maximilian is a pet Campbell hamster. Maximilian doesn't like any food.", result);
        }

        [Fact]
        public void CreateAPetHamsterWhoLikesThreeTypesOfFood()
        {
            var h = new Hamster("Dexter", true, HamsterSpecie.Syrian);
            h.LikesFood = new List<string> { "seeds", "fruits", "insects" };
            string result = h.Description();
            Assert.Equal("Dexter is a pet Syrian hamster. Dexter likes 3 types of food.", result);
        }

        [Fact]
        public void CreateAPetHamsterWhoLikesTwoTypesOfFood()
        {
            var h = new Hamster("Chiquita", true, HamsterSpecie.Roborovski);
            h.LikesFood = new List<string> { "fruits", "insects" };
            string result = h.Description();
            Assert.Equal("Chiquita is a pet Roborovski hamster. Chiquita likes 2 types of food.", result);
        }

        [Fact]
        public void CreateAWildHamsterWhoLikesOneTypeOfFood()
        {
            var h = new Hamster("Goldilocks", false, HamsterSpecie.WinterWhite);
            h.LikesFood = new List<string> { "insects" };
            string result = h.Description();
            // Info to student: note that we expect "type" instead of "types"
            Assert.Equal("Goldilocks is a wild WinterWhite hamster. Goldilocks likes 1 type of food.", result);
        }

        // Create a new constructor so that the following test will pass.
        // The new constructor should give some default data for the hamster
        // (a winterwhite wild hamster who likes insects)
        [Fact]
        public void CreateAHamsterCreatedWithAlternativeConstructor()
        {
            var b = new HamsterBurrow(10.77, 20.55);
            var h = new Hamster("Jojo", b);

            string position = h.GetBurrowPosition();
            // Hint: use ToString("#.##") to format the position
            Assert.Equal("Jojo has a burrow at longitude 10,77 and latitude 20,55", position);

            Assert.False(h.IsPet);
            Assert.Equal("Jojo is a wild WinterWhite hamster. Jojo likes 1 type of food.", h.Description());
            Assert.Single(h.LikesFood); // Single verifies that the given collection contains only a single element.
            Assert.Equal("insects", h.LikesFood[0]);

            // Now, Jojo don't have a burrow anymore
            h.HamsterBurrow = null;

            Assert.Equal("Jojo doesn't have a burrow", h.GetBurrowPosition());
        }
    }
}