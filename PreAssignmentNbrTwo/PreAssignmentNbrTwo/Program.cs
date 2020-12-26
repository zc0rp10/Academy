using System;

namespace PreAssignmentNbrTwo
{
    class Program
    {
        static ShoppingList shoppingList = new ShoppingList();
        public static bool endApp = false;

        static void Main(string[] args)
        {
            try
            {
                while (!endApp)
                {
                    Ui.DrawView(shoppingList);
                    Ui.ListenForKeyPress(shoppingList);
                }
                // Note: Point to discuss with teacher, all methods in Ui class was previously contained below in the Program class. I decided to move
                // them into a seperate class to keep each file smaller in terms of lines and more readable. I'm however to sure that the way I went about
                // it was necessarily the best. It **feels** messy, passing in shoppingList as an argument in each function call, as well as interacting
                // with Program.endApp the day I do from the Ui.ListenForKeyPress method.
                // - Should I perhaps have moved shoppingList field into the Ui class?
                // - Should I perhaps have moved endApp field into Ui class? But is using `while(!Ui.endApp)` from Program Class really any less messy than using
                //   `case ConsoleKey.Q: { Program.endApp = true; break; }` from Ui Class?
            }
            catch (Exception e)
            {
                Console.WriteLine("> ERROR: Oops, something went wrong...");
                Console.WriteLine("> ERROR: " + e.Message);
            }
        }
    }
}
