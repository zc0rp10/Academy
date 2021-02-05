using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalLibrary
{
    public class Hamster
    {
        public Hamster(string name, bool isPet, HamsterSpecie specie)
        {
            Name = name;
            IsPet = isPet;
            Specie = specie;
        }

        public Hamster(string name, HamsterBurrow burrow)
        {
            Name = name;
            HamsterBurrow = burrow;
            IsPet = false;
            Specie = HamsterSpecie.WinterWhite;
            LikesFood = new List<String>() { "insects" };
        }

        public string Name { get; set; }
        public bool IsPet { get; set; }
        public HamsterSpecie Specie { get; set; }
        public List<String> LikesFood;
        public HamsterBurrow HamsterBurrow;

        public string Greet()
        {
            return $"{Name} is a {(IsPet == true ? "pet" : "wild")} {Specie} hamster.";
        }

        public string Description()
        {
            string likesString;

            if (LikesFood == null)
                likesString = @"doesn't like any";
            else if (LikesFood.Count == 1)
                likesString = $"likes {LikesFood.Count} type of";
            else
                likesString = $"likes {LikesFood.Count} types of";

            return $"{Greet()} {Name} {likesString} food.";
        }

        public string GetBurrowPosition()
        {
            if (HamsterBurrow == null)
                return $"{Name} doesn't have a burrow";
            else
                return $"{Name} has a burrow at longitude {string.Format("{0:#.##}", HamsterBurrow.Longitude)} and latitude {string.Format("{0:#.##}", HamsterBurrow.Latitude)}";
        }
    }
}
