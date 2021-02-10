using System;
using System.Linq;

namespace QueryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var robots = new[]
            {
                new Robot("R2-D2", 500),
                new Robot("Bender", 50),
                new Robot("Wall-E", 1000),
                new Robot("Data", 9000)
            };

            var q = robots
                .Where(r => r.Price > 500)
                .Select(r => new
                {
                    Model = r.Model,
                    Price = r.Price,
                    Created = DateTime.Now
                });

            var longestModelName = robots
                .OrderByDescending(r => r.Model.Length)
                .First();

            //Console.WriteLine(longestModelName);
        }
    }

    class Robot
    {
        public Robot(string model, int price)
        {
            Model = model;
            Price = price;
        }

        public string Model { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"Model: {Model}\tPrice: {Price}";
        }

    }
}
