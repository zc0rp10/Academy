using System;
using System.Collections.Generic;

namespace ListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();
            names = AddName("Adam", names);
            names = AddName("Eva", names);
            names = AddName("Bosse", names);
            names = RemoveName("Adam", names);
            names.Sort();
            RemoveNameUserInput(names);

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }

        private static void RemoveNameUserInput(List<string> list)
        {
            Console.Write("Enter the name you would like to remove: ");
            string name = Console.ReadLine().ToLower();
            RemoveName(name, list);
        }

        private static List<string> RemoveName(string name, List<string> list)
        {
            list.Remove(name.ToLower());
            return list;
        }

        private static List<string> AddName(string name, List<string> list)
        {
            list.Add(name.ToLower());
            return list;
        }
    }
}
