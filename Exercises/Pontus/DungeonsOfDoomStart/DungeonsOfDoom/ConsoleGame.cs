using DungeonsOfDoom.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WMPLib;



namespace DungeonsOfDoom
{
    class ConsoleGame
    {
        Player player;
        Room[,] world;
        Random random = new Random();
        FxPlayer bgMusic = new FxPlayer();
        FxPlayer fxPlayer = new FxPlayer();
        int nbrOfMonsters = 0;
        

        public void Play()
        {
            TitleScreen();
            CreatePlayer();
            DisplaySynopsis();
            CreateWorld();
            new Sword(Items.SwordType.Copper);

            do
            {
                Console.Clear();
                DisplayWorld();
                DisplayStats();
                AskForMovement();
                RoomEvent();
                if (nbrOfMonsters == 0)
                    GameWon();
            } while (player.Health > 0);
            GameOver();
        }

        private void DisplaySynopsis()
        {
            Console.Clear();
            Console.WriteLine("+--------------------------------------------------------------------------------------------+");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            ConsoleGameUtils.RollingText("                                                                                              \n                                                                                              \n                                                                                              \n                                                                                              \n                                                                                              \n                                                                                              \n                                                                                              \n                                                                                              \n                                                                                              \n                                                                                              \n    Dungeons of Doom is a psychological dungeon crawler where deranged former programming   \n    student ", 50);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            ConsoleGameUtils.RollingText(player.Name);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            ConsoleGameUtils.RollingText(" battles their way through the rooms of the asylum, looting items in search\n    of the legendary ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            ConsoleGameUtils.RollingText("God Eater");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            ConsoleGameUtils.RollingText(" sword. So he can once and for all slay his former master and      \n    teacher PontWitt - and in so graduate from the ");
            Console.ForegroundColor = ConsoleColor.Green;
            ConsoleGameUtils.RollingText("Academy!                                   \n                                                                                              \n                                                                                              \n                                                                                              \n                                                                                              \n                                                                                              \n                                                                                              \n                                                                                              \n                                                                                              \n", 75);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("+--------------------------------------------------------------------------------------------+");
            Console.ReadKey(true);
            
        }

        private void RoomEvent()
        {
            var currentRoom = world[player.X, player.Y];

            if (currentRoom.Item != null)
            {
                player.Backpack.Add(currentRoom.Item);
                currentRoom.Item.AffectPlayer(player);
                currentRoom.Item = null;
            }
            else if (currentRoom.Monster != null)
            {
                bool victory = Battle(player, currentRoom.Monster);
                if (victory)
                {
                    if (currentRoom.Monster.Name == "PontWitt")
                    {
                        GameWon();
                    }
                    else
                        Console.WriteLine($"{player.Name} won the battle!");

                    currentRoom.Monster = null;
                    nbrOfMonsters--;
                    Console.ReadKey();
                }
            }
        }


        private bool Battle(Player player, Monster monster)
        {
            Console.Clear();
            Console.WriteLine("====== BATTLE ======");
            do
            {
                fxPlayer.PlayHit();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                int dmg = player.TakeDamage(monster.Attack(player));
                Console.WriteLine($"{monster.Name} attacks {player.Name} for {dmg} damage.");

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                dmg = monster.TakeDamage(player.Attack(monster));
                Console.WriteLine($"{player.Name} attacks {monster.Name} for {dmg} damage.");
                Console.ReadKey(true);
                Console.ForegroundColor = ConsoleColor.White;
            } while (player.Health > 0 && monster.Health > 0);

            if (player.Health <= 0)
                return false;
            else
                return true;
        }

        private void CreatePlayer()
        {
            string name;
            do
            {
                ConsoleGameUtils.RollingText("Enter your name and press enter..\n> ", 75);
                Console.ForegroundColor = ConsoleColor.White;
                name = Console.ReadLine();
            } while (name.Length == 0); ;
            player = new Player(name, 300, 10, 50, 0, 0);
        }

        private void CreateWorld()
        {
            world = new Room[20, 5];
            for (int y = 0; y < world.GetLength(1); y++)
            {
                for (int x = 0; x < world.GetLength(0); x++)
                {
                    world[x, y] = new Room();

                    if (y == world.GetLength(1) - 1 && x == world.GetLength(0) - 1)
                        world[x, y].Monster = new Monsters.PontWitt(1000, 100);
                    else
                    {
                        int percentage = random.Next(0, 100);
                        if (percentage < 10) // 6 - 10
                        {
                            world[x, y].Monster = RandomMonster();
                            nbrOfMonsters++;
                        }
                        else if (percentage < 20) // 11 - 20
                            world[x, y].Item = RandomItem();
                        // 21 - 99 = Tomt Rum
                    }
                }
            }
        }

        private Monster RandomMonster()
        {
            int percentage = random.Next(0, 100);

            if (percentage < 11)
                return new Werewolf(200, 30);
            else
                return new Skeleton(100, 20);
        }
        private Item RandomItem()
        {
            int percentage = random.Next(0, 100);

            if (percentage < 10)
                return new Sword(Items.SwordType.GodEater);
            else if (percentage < 20)
                return new Sword(Items.SwordType.Iron);
            else if (percentage < 45)
                return new Sword(Items.SwordType.Copper);
            else if (percentage < 85)
                return new Potion(/*Items.PotionType.Health*/);
            else if (percentage < 95)
                return new Poison();
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
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("P");
                        Console.ForegroundColor = ConsoleColor.White;

                    }

                    else if (room.Monster != null)
                        if (room.Monster.Name == "PontWitt")
                            Console.Write("B");
                        else
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
            Console.WriteLine($"Strength: {player.Strength}");
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
                if (item.Key == "GodEater Sword")
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine($"{item.Key} x {item.Value}");
                }
                else if (item.Key == "Iron Sword")
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

        private void GameWon()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"\nCongrats {player.Name} has defeated PontWitt and won the game!");
            bgMusic.stop();
            fxPlayer.PlayVictory();
            Console.ReadKey(true);
            Play();
        }

        private void TitleScreen()
        {
            string[,] string2DArr = new string[24, 94] {
                              { "+","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","+"},
                              { " "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "},
                              { " ","▓","█","█","█","█","█","▄"," "," ","█"," "," "," "," ","█","█"," "," ","█","█","█","▄"," "," "," "," ","█"," "," "," ","▄","█","█","█","█"," ","▓","█","█","█","█","█"," "," ","▒","█","█","█","█","█"," "," "," ","█","█","█","▄"," "," "," "," ","█"," "," "," ","█","█","█","█","█","█"," "," "," "," "," ","▒","█","█","█","█","█"," "," "," "," ","█","█","█","█","█","▒"," "},
                              { " ","▒","█","█","▀"," ","█","█","▌"," ","█","█"," "," ","▓","█","█","▒"," ","█","█"," ","▀","█"," "," "," ","█"," "," ","█","█","▒"," ","▀","█","▒","▓","█"," "," "," ","▀"," ","▒","█","█","▒"," "," ","█","█","▒"," ","█","█"," ","▀","█"," "," "," ","█"," ","▒","█","█"," "," "," "," ","▒"," "," "," "," ","▒","█","█","▒"," "," ","█","█","▒","▓","█","█"," "," "," ","▒"," "," "},
                              { " ","░","█","█"," "," "," ","█","▌","▓","█","█"," "," ","▒","█","█","░","▓","█","█"," "," ","▀","█"," ","█","█","▒","▒","█","█","░","▄","▄","▄","░","▒","█","█","█"," "," "," ","▒","█","█","░"," "," ","█","█","▒","▓","█","█"," "," ","▀","█"," ","█","█","▒","░"," ","▓","█","█","▄"," "," "," "," "," "," ","▒","█","█","░"," "," ","█","█","▒","▒","█","█","█","█"," ","░"," "," "},
                              { " ","░","▓","█","▄"," "," "," ","▌","▓","▓","█"," "," ","░","█","█","░","▓","█","█","▒"," "," ","▐","▌","█","█","▒","░","▓","█"," "," ","█","█","▓","▒","▓","█"," "," ","▄"," ","▒","█","█"," "," "," ","█","█","░","▓","█","█","▒"," "," ","▐","▌","█","█","▒"," "," ","▒"," "," "," ","█","█","▒"," "," "," ","▒","█","█"," "," "," ","█","█","░","░","▓","█","▒"," "," ","░"," "," "},
                              { " ","░","▒","█","█","█","█","▓"," ","▒","▒","█","█","█","█","█","▓"," ","▒","█","█","░"," "," "," ","▓","█","█","░","░","▒","▓","█","█","█","▀","▒","░","▒","█","█","█","█","▒","░"," ","█","█","█","█","▓","▒","░","▒","█","█","░"," "," "," ","▓","█","█","░","▒","█","█","█","█","█","█","▒","▒"," "," "," ","░"," ","█","█","█","█","▓","▒","░","░","▒","█","░"," "," "," "," "," "},
                              { " "," ","▒","▒","▓"," "," ","▒"," ","░","▒","▓","▒"," ","▒"," ","▒"," ","░"," ","▒","░"," "," "," ","▒"," ","▒"," "," ","░","▒"," "," "," ","▒"," ","░","░"," ","▒","░"," ","░","░"," ","▒","░","▒","░","▒","░"," ","░"," ","▒","░"," "," "," ","▒"," ","▒"," ","▒"," ","▒","▓","▒"," ","▒"," ","░"," "," "," ","░"," ","▒","░","▒","░","▒","░"," "," ","▒"," ","░"," "," "," "," "," "},
                              { " "," ","░"," ","▒"," "," ","▒"," ","░","░","▒","░"," ","░"," ","░"," ","░"," ","░","░"," "," "," ","░"," ","▒","░"," "," ","░"," "," "," ","░"," "," ","░"," ","░"," "," ","░"," "," ","░"," ","▒"," ","▒","░"," ","░"," ","░","░"," "," "," ","░"," ","▒","░","░"," ","░","▒"," "," ","░"," ","░"," "," "," "," "," ","░"," ","▒"," ","▒","░"," "," ","░"," "," "," "," "," "," "," "},
                              { " "," ","░"," ","░"," "," ","░"," "," ","░","░","░"," ","░"," ","░"," "," "," "," ","░"," "," "," ","░"," ","░"," ","░"," ","░"," "," "," ","░"," "," "," "," ","░"," "," "," ","░"," ","░"," ","░"," ","▒"," "," "," "," "," ","░"," "," "," ","░"," ","░"," ","░"," "," ","░"," "," ","░"," "," "," "," "," ","░"," ","░"," ","░"," ","▒"," "," "," ","░"," ","░"," "," "," "," "," "},
                              { " "," "," "," ","░"," "," "," "," "," "," "," ","░"," "," "," "," "," "," "," "," "," "," "," "," "," "," ","░"," "," "," "," "," "," "," ","░"," "," "," "," ","░"," "," ","░"," "," "," "," ","░"," ","░"," "," "," "," "," "," "," "," "," "," "," ","░"," "," "," "," "," "," "," ","░"," "," "," "," "," "," "," "," "," ","░"," ","░"," "," "," "," "," "," "," "," "," "," "," "},
                              { " "," ","░"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "},
                              { " "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","▓","█","█","█","█","█","▄"," "," ","▒","█","█","█","█","█"," "," "," ","▒","█","█","█","█","█"," "," "," ","█","█","█","▄"," ","▄","█","█","█","▓"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "},
                              { " "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","▒","█","█","▀"," ","█","█","▌","▒","█","█","▒"," "," ","█","█","▒","▒","█","█","▒"," "," ","█","█","▒","▓","█","█","▒","▀","█","▀"," ","█","█","▒"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "},
                              { " "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","░","█","█"," "," "," ","█","▌","▒","█","█","░"," "," ","█","█","▒","▒","█","█","░"," "," ","█","█","▒","▓","█","█"," "," "," "," ","▓","█","█","░"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "},
                              { " "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","░","▓","█","▄"," "," "," ","▌","▒","█","█"," "," "," ","█","█","░","▒","█","█"," "," "," ","█","█","░","▒","█","█"," "," "," "," ","▒","█","█"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "},
                              { " "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","░","▒","█","█","█","█","▓"," ","░"," ","█","█","█","█","▓","▒","░","░"," ","█","█","█","█","▓","▒","░","▒","█","█","▒"," "," "," ","░","█","█","▒"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "},
                              { " "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","▒","▒","▓"," "," ","▒"," ","░"," ","▒","░","▒","░","▒","░"," ","░"," ","▒","░","▒","░","▒","░"," ","░"," ","▒","░"," "," "," ","░"," "," ","░"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "},
                              { " "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","░"," ","▒"," "," ","▒"," "," "," ","░"," ","▒"," ","▒","░"," "," "," ","░"," ","▒"," ","▒","░"," ","░"," "," ","░"," "," "," "," "," "," ","░"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "},
                              { " "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","░"," ","░"," "," ","░"," ","░"," ","░"," ","░"," ","▒"," "," ","░"," ","░"," ","░"," ","▒"," "," ","░"," "," "," "," "," "," ","░"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "},
                              { " "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","░"," "," "," "," "," "," "," "," ","░"," ","░"," "," "," "," "," "," ","░"," ","░"," "," "," "," "," "," "," "," "," ","░"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "},
                              { " "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","░"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "},
                              { " "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "},
                              { "+","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","-","+"}
            };

            bgMusic.PlayTheme();
            Console.Clear();
           
            int rowLength = string2DArr.GetLength(0);
            int colLength = string2DArr.GetLength(1);
            for (int i = 0; i < rowLength; i++)
            {
                if (i == 0 || i == 23)
                    Console.ForegroundColor = ConsoleColor.White;
                else
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0}", string2DArr[i, j]));
                }
                Console.Write(Environment.NewLine);
            }
            Console.ForegroundColor = ConsoleColor.DarkGray;
        }

        public static void playSound(SoundPlayer s)
        {
            s.PlaySync();
        }
    }
}
