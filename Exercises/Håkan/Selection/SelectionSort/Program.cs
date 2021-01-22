using System;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] characters = new char[5] { 'b', 'e', 'a', 'c', 'd' };

            SelectionSort(characters);
            foreach (var item in characters)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            characters = new char[5] { 'b', 'e', 'a', 'c', 'd' };
            BubbleSort(characters);

            foreach (var item in characters)
            {
                Console.Write(item);
            }
        }

        private static void BubbleSort(char[] characters)
        {
            int p = 1;
            for (int i = 0; i < characters.Length - 1; i++)
            {
                int lvi = i;
                for (int j = i + 1; j < characters.Length; j++)
                {
                    if (characters[j] < characters[lvi])
                    {
                        char x = characters[j];
                        char y = characters[lvi];
                        characters[j] = y;
                        characters[lvi] = x;
                    }
                    Console.WriteLine(p++);
                }

            }
        }

        private static void SelectionSort(char[] characters)
        {
            for (int i = 0; i < characters.Length - 1; i++)
            {
                int lvi = i;
                for (int j = i + 1; j < characters.Length; j++)
                {
                    if (characters[j] < characters[lvi])
                        lvi = j;
                }
                if (lvi != i)
                {

                    char tmp = characters[i];
                    characters[i] = characters[lvi];
                    characters[lvi] = tmp;
                }
            }
        }


    }
}
