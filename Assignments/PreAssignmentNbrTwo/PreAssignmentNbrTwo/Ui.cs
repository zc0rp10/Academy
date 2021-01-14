using System;
using System.Linq;

namespace PreAssignmentNbrTwo
{
    class Ui
    {
        public static void DrawView(ShoppingList shoppingList)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Shopping List Application");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("These are your current items to buy:");
            Console.WriteLine();
            Console.WriteLine("Id\tName\t\t\t\tPrice");
            Console.WriteLine("--\t----------\t\t\t-----");

            foreach (var item in shoppingList.Ingredients)
            {
                // TODO: Dynamically adjust spacing between item.Name and item.Price so it lines up correctly in the columns regardless of
                // the diffrence in length between item names.
                if (shoppingList.Ingredients.Count > 1)
                {

                    if (item.Price == shoppingList.Ingredients.Max(item => item.Price))
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                    if (item.Price == shoppingList.Ingredients.Min(item => item.Price))
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                }

                Console.WriteLine($"{shoppingList.Ingredients.IndexOf(item) + 1}\t{item.Name}\t\t\t\t{item.Price} kr");

                Console.BackgroundColor = ConsoleColor.Black;
            }

            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("| A - Add Ingredient  | R - Remove Ingredient  |");
            Console.WriteLine("| E - Edit Ingredient | S - Sort By | Q - Quit |");
            Console.WriteLine();
        }

        public static void ListenForKeyPress(ShoppingList shoppingList)
        {
            {
                ConsoleKeyInfo keyInfo;
                keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.A: { shoppingList.Add(); break; }
                    case ConsoleKey.R: { shoppingList.Remove(); ; break; }
                    case ConsoleKey.E: { shoppingList.Edit(); break; }
                    case ConsoleKey.S:
                        {
                            Console.Write("Select sort order, P - Price, N - Name: ");
                            keyInfo = Console.ReadKey(true);
                            switch (keyInfo.Key)
                            {
                                case ConsoleKey.P: { shoppingList.ListOrder = ShoppingList.Order.Price; break; }
                                case ConsoleKey.N: { shoppingList.ListOrder = ShoppingList.Order.Name; break; }
                                default: break;
                            }
                            break;
                        }
                    case ConsoleKey.Escape:
                    case ConsoleKey.Q: { Program.endApp = true; break; }
                    default: break;
                }
            }
        }
    }
}
