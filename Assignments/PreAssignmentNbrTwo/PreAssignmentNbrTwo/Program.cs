using System;

//Utöver projektfilerna så la jag med en gif med screen recording från min dator i zip filen om för att visa alla funktionerna.

//Funktioner:
//- Användaren navigerar i applikationen med tangentbords tryck för att välja vad hen vill göra härnäst.
//- Användaren kan Skapa, Uppdatera, Ta Bort ingredienser från shoppinglistan.
//- Användaren kan sortera ingredienser på shoppinglistan efter Pris (Default) eller Namn.
//- Användarens ingredienser sparas till en fil (C:\Users\ANVÄNDARE\AppData\Roaming\ShoppingListApp) varje gång det sker en uppdatering. Dessa ingredienser läses sedan in från filen nästa gång programmet startas och man kan fortsätta arbeta där man slutade.

//Classes:
//Program.cs: Skapar en instance av ShopingList och kör sedan programmets huvudloop.
//Ingredient.cs: Fungerar som model för hur en ingredient skall se ut som läggs till på shoppinglistan.
//ShoppingList.cs: Består av en List som äger alla Ingredients på listan, samt funktioner för att lägga till, ta bort editera från den listan.
//Ui.cs: Ritar upp UI i konsolen på varje loop och lyssnar sedan efter användarens tangentinmatning för att välja vad som skall hända härnäst.
//AppState.cs: Ansvarar för att spara ned varje gång användaren gör ändringar på shoppinglistan. Samt läsa in ingredienser från föregående session när programmet startas upp nästa gång.

//Övrigt: Jag har skrivit en del kommentarer i koden där problem och tankegångar uppstod som jag gärna skulle diskutera bättre/annorlunda lösningar på vid tillfälle.

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
                AppState.Load(shoppingList);

                while (!endApp)
                {
                    Ui.DrawView(shoppingList);
                    Ui.ListenForKeyPress(shoppingList);
                    AppState.Save(shoppingList.Ingredients);
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
