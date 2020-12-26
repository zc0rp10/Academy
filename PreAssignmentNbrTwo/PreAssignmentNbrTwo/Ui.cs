using System;

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
                // TODO: Dynamically adjust spacing between item.Name and item.Price so it lines up correctly in the columns regardles of
                // the diffrence of length in item names.
                Console.WriteLine($"{shoppingList.Ingredients.IndexOf(item) + 1}\t{item.Name}\t\t\t\t{item.Price}kr");
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
                    case ConsoleKey.E: { Console.WriteLine("Edit Ingredient"); break; }
                    case ConsoleKey.S: { Console.WriteLine("Sort Order"); break; }
                    case ConsoleKey.Escape:
                    case ConsoleKey.Q: { Program.endApp = true; break; }
                    default: break;
                }
            }
        }
    }
}
