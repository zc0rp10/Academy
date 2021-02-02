using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsOfDoom
{
    class ConsoleGame
    {
        Player player;
        Room[,] world;
        Random random = new Random();

        public void Play()
        {
            CreatePlayer();
            CreateWorld();
            new Sword(Items.SwordType.Copper);

            do
            {
                Console.Clear();
                DisplayWorld();
                DisplayStats();
                AskForMovement();
                RoomEvent();
            } while (player.Health > 0);
            GameOver();
        }

        private void RoomEvent()
        {
            var currentRoom = world[player.X, player.Y];

            if (currentRoom.Item != null)
            {
                player.Backpack.Add(currentRoom.Item);
                currentRoom.Item = null;
            }
            else if (currentRoom.Monster != null)
            {
                bool victory = Battle(player, currentRoom.Monster);
                if (victory)
                {
                    currentRoom.Monster = null;
                    Console.WriteLine("Congrats you won!");
                    Console.ReadKey();
                }
            }
        }

        private bool Battle(Player player, Monster monster)
        {
            // TODO: Return the Character that won, or a bool true, if player won.
            Console.Clear();
            Console.WriteLine("====== BATTLE ======");
            do
            {
                monster.TakeDamage(player.Attack());
                player.TakeDamage(monster.Attack());

            } while (player.Health > 0 && monster.Health > 0);

            if (player.Health <= 0)
                return false;
            else
                return true;
        }

        private void CreatePlayer()
        {
            player = new Player(300, 10, 10, 0, 0);
        }

        private void CreateWorld()
        {
            world = new Room[20, 5];
            for (int y = 0; y < world.GetLength(1); y++)
            {
                for (int x = 0; x < world.GetLength(0); x++)
                {
                    world[x, y] = new Room();

                    int percentage = random.Next(0, 100);
                    if (percentage < 10) // 6 - 10
                        world[x, y].Monster = RandomMonster();
                    else if (percentage < 20) // 11 - 20
                        world[x, y].Item = RandomItem();
                    // 21 - 99 = Tomt Rum
                }
            }
        }

        private Monster RandomMonster()
        {
            int percentage = random.Next(0, 100);

            if (percentage < 1)
                return new Werewolf(100, 20, true);
            else if (percentage < 11)
                return new Werewolf(100, 20, false);
            else
                return new Skeleton(100, 10);
        }
        private Item RandomItem()
        {
            int percentage = random.Next(0, 100);

            if (percentage < 10)
                return new Sword(Items.SwordType.Iron);
            else if (percentage < 25)
                return new Sword(Items.SwordType.Copper);
            else if (percentage < 50)
                return new Potion(Items.PotionType.Health);
            else
                return new Items.Junk("Worthless Junk");
        }

        private void DisplayWorld()
        {
            Console.WriteLine("======= MAP ========");
            for (int y = 0; y < world.GetLength(1); y++)
            {
                for (int x = 0; x < world.GetLength(0); x++)
                {
                    Room room = world[x, y];
                    if (player.X == x && player.Y == y)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("P");
                        Console.ForegroundColor = ConsoleColor.White;

                    }

                    else if (room.Monster != null)
                        Console.Write("M");
                    else if (room.Item != null)
                        Console.Write("I");
                    else
                        Console.Write(".");
                }
                Console.WriteLine();
            }
        }

        private void DisplayStats()
        {
            Console.WriteLine();
            Console.WriteLine("====== PLAYER ======");
            Console.WriteLine($"Health: {player.Health}");
            Console.WriteLine();
            Console.WriteLine("===== BACKPACK =====");

            Dictionary<string, int> inventory = new Dictionary<string, int>();
            foreach (var item in player.Backpack)
            {
                if (inventory.ContainsKey(item.Name))
                    inventory[item.Name] += 1;
                else
                    inventory.Add(item.Name, 1);
            }


            foreach (var item in inventory)
            {
                if (item.Key == "Iron Sword")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{item.Key} x {item.Value}");
                }
                else if (item.Key == "Worthless Junk")
                {

                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine($"{item.Key} x {item.Value}");
                }
                else
                {
                    Console.WriteLine($"{item.Key} x {item.Value}");
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        private void AskForMovement()
        {
            int newX = player.X;
            int newY = player.Y;
            bool isValidKey = true;

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            switch (keyInfo.Key)
            {
                case ConsoleKey.RightArrow: newX++; break;
                case ConsoleKey.LeftArrow: newX--; break;
                case ConsoleKey.UpArrow: newY--; break;
                case ConsoleKey.DownArrow: newY++; break;
                default: isValidKey = false; break;
            }

            if (isValidKey &&
                newX >= 0 && newX < world.GetLength(0) &&
                newY >= 0 && newY < world.GetLength(1))
            {
                player.X = newX;
                player.Y = newY;
            }
        }

        private void GameOver()
        {
            Console.Clear();
            Console.WriteLine("Game over...");
            Console.ReadKey();
            Play();
        }
    }
}
