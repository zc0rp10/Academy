using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assessment.Divers
{
    public enum Direction
    {
        Up,
        Down
    }

    public class Diver
    {
        public Diver(string name)
        {
            Name = name;
            Position = 0;
            FavoriteFishes = new List<string>();
        }

        public string Name { get; }
        public int Position { get; set; }
        public Direction Orientation { get; set; }
        public List<string> FavoriteFishes { get; set; }

        public void Swim()
        {
            if (Orientation == Direction.Down)
                Position--;
            else if (Orientation == Direction.Up)
                Position++;
        }

        public void SetDirectionDown()
        {
            Orientation = Direction.Down;
        }

        public void SetDirectionUp()
        {
            Orientation = Direction.Up;
        }

        public int GetPosition()
        {
            return Position;
        }

        public void AddFish(string species)
        {
            FavoriteFishes.Add(species);
           
        }

        public string GetDescription()
        {
            if (FavoriteFishes.Count == 0)
                return $"{Name} doesn't like any fish";

            var sb = new StringBuilder();
            for (int i = 0; i < FavoriteFishes.Count; i++)
            {
                sb.Append(FavoriteFishes[i]);
                if (i != FavoriteFishes.Count - 1)
                    sb.Append(",");
            }

            string fishListString =  sb.ToString().ToLower();

            return $"{Name} likes {fishListString}";
        }

        public List<string> FishesSortedAlphabetically(int charCount)
        {
            var filteredFishList = new List<String>();

            foreach (var fish in FavoriteFishes)
            {
                if (fish.Length >= charCount)
                    filteredFishList.Add(fish);
            }

            filteredFishList.Sort();

            return filteredFishList;
        }

        public List<string> FishesSortedAlphabetically_Linq(int charCount)
        {
            var q = FavoriteFishes
                .Where(f => f.Length >= charCount)
                .OrderBy(f => f)
                .ToList();

            return q;
        }
    }
}
