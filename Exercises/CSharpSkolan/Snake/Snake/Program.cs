using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Snake
{
    class Program
    {
        struct Point
        {
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public int X { get; set; }
            public int Y { get; set; }
        }

        static void Main(string[] args)
        {
            string[,] map =
            {
                // x --->
                { ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". "  }, // y
                { ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". "  }, // |
                { ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". "  }, // V
                { ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". "  },
                { ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". "  },
                { ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". "  },
                { ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". "  },
                { ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". "  },
                { ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". "  },
                { ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". ", ". "  }
            };

            int points = 0;
            bool isDead = false;
            Point candy = new Point(1, 4);
            Point direction = new Point(1, 0);
            List<Point> masken = new List<Point>();
            masken.Add(new Point(4, 4));
            masken.Add(new Point(3, 4));
            masken.Add(new Point(2, 4));

            while (!isDead)
            {
                // Rita Spelet
                Console.Clear();
                for (int y = 0; y < map.GetLength(0); y++)
                {
                    for (int x = 0; x < map.GetLength(1); x++)
                    {
                        Point currentPosition = new Point(x, y);

                            if (masken.Contains(currentPosition))
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Write("  ");
                            Console.BackgroundColor = ConsoleColor.Black;
                        }
                        else if (candy.Equals(currentPosition))
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Write("  ");
                            Console.BackgroundColor = ConsoleColor.Black;
                        }
                        else
                            Console.Write(map[y, x]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine($"Points: {points}");
                // Vänta på input i ca 500ms
                Stopwatch sw = Stopwatch.StartNew();
                while (sw.ElapsedMilliseconds < 500)
                {
                    if (Console.KeyAvailable)
                    {
                        var key = Console.ReadKey(true);
                        if (key.Key == ConsoleKey.LeftArrow)
                        {
                            direction = new Point(direction.Y, -direction.X);
                        }

                        if (key.Key == ConsoleKey.RightArrow)
                        {
                            direction = new Point(-direction.Y, direction.X);
                        }
                    }
                }

                // Gör förflyttning och logik etc.
                Point head = masken[0];
                Point newPosition = new Point(head.X + direction.X, head.Y + direction.Y);

                if (masken.Contains(newPosition))
                {
                    isDead = true;
                    Console.WriteLine("GAME OVER!");
                }

                masken.Insert(0, newPosition);

              

                if (head.Equals(candy))
                {
                    Random rnd = new Random();
                    candy = new Point(rnd.Next(0, 10), rnd.Next(0, 10));
                    points = points + 100;
                }
                else
                    masken.RemoveAt(masken.Count - 1);

                if (newPosition.X < 0 || newPosition.X > 9 || newPosition.Y < 0 || newPosition.Y > 9)
                {
                    isDead = true;
                    Console.WriteLine("GAME OVER!");
                }

             
            }
        }
    }
}
