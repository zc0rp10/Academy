using System;

namespace StringArrManipulation
{
    static class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[2] { "Adam", "Eva" };
            names = AddName(names, "Håkan");

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            Console.Write("Enter the name you want to remove: ");
            string name = Console.ReadLine();
            

            names = RemoveName(names, name);


            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

            //SortNames(names);
        }

        private static void SortNames(string[] names)
        {
            throw new NotImplementedException();
        }

        private static string[] AddName(string[] names, string name)
        {
            string[] temp = new string[names.Length + 1];
            temp[names.Length] = name;

            for (int i = 0; i < names.Length; i++)
            {
                temp[i] = names[i];
            }
            return temp;
            
        }

        private static string[] RemoveName(string[] names, string name)
        {
            string[] temp = new string[names.Length - 1];
            bool nameFound = false;

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                {
                    nameFound = true;
                }
                else
                {
                    if (nameFound == false)
                        temp[i] = names[i];
                    else
                        temp[i-1] = names[i];
                }
            }
            return temp;
        }
    }
}
