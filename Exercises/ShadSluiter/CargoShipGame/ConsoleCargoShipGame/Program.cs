using LibCargoShip;
using System;

namespace ConsoleCargoShipGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship();

            string WelcomeMessage = "Welcome to Cargo Ship. The goal of this game is to lead the ship to its maximum capacity by adding" +
                "motor cycles, cars, trucks and train cars. A cycle takes 3 units of weight. A car takes 5 units. A truck takes 11 units. " +
                "A train car takes 17 units.";

            // Repeat until the player gets the ship loaded to max capacity
            while (ship.Capacity != ship.GetShipLoad())
            {
                Console.Clear();
                Console.WriteLine(WelcomeMessage);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("The ship capacity is " + ship.Capacity);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"The ship has {ship.CycleCount} motorcycles on board.");
                Console.WriteLine($"The ship has {ship.CarCount} cars on board.");
                Console.WriteLine($"The ship has {ship.TruckCount} trucks on board.");
                Console.WriteLine($"The ship has {ship.TrainCarCount} train cars on board.");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"The ship currently has {ship.GetShipLoad()} total units on board.");
                Console.ForegroundColor = ConsoleColor.White;

                ship.CycleCount = GetInput("motorcycles");
                ship.CarCount = GetInput("cars");
                ship.TruckCount = GetInput("trucks");
                ship.TrainCarCount = GetInput("train cars");

                Console.WriteLine($"The ship now has {ship.GetShipLoad()} total units of weight on board.");

                if (ship.OverUnder() > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("The ship still has room to spare. Load more items.");
                }

                if (ship.OverUnder() < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The ship is overloaded. Unload some items.");
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You loaded the ship successfully!");
        }

        static int GetInput(string unit)
        {
            Console.WriteLine($"How many {unit} would you like to put on the ship?");
            return int.Parse(Console.ReadLine());
        }
    }
}
