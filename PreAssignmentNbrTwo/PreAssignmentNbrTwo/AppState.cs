using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PreAssignmentNbrTwo
{
    class AppState
    {
        //Note: Point to discuss with teacher, is there a commonly used Class Name for this type of class that aims to persist application state?
        static string directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"/ShoppingListApp";
        static string filePath = directoryPath + "/data.csv";

        public static void Save(List<Ingredient> shoppingList)
        {
            Directory.CreateDirectory(directoryPath);

            List<string> output = new List<string>();
            foreach (var item in shoppingList)
            {
                output.Add($"{item.Name},{item.Price}");
            }

            File.WriteAllLines(filePath, output);
        }

        public static void Load(ShoppingList shoppingList)
        {
            if (File.Exists(filePath))
            {
                List<string> lines = File.ReadAllLines(filePath).ToList();
                foreach (var line in lines)
                {
                    string[] entries = line.Split(",");
                    shoppingList.Ingredients.Add(new Ingredient(entries[0], int.Parse(entries[1]))); //Order: Name, Price
                }
            }
        }
    }
}
