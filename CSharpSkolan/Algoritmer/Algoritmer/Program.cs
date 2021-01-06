using System;

namespace Algoritmer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Max var: " + HittaMax());
            Console.WriteLine("Värdet finns vid index: " + SekventiellSök(new int[] { 3, 6, 8, 2, 5, 9, 1 }, 2));
            Console.WriteLine("Värder finns vid index: " + BinärSök(new int[] { 3, 5, 6, 7, 9, 10, 12, 15, 16, 17, 19, 21, 22, 23 }, 15));
        }

        static int HittaMax()
        {
            int[] numbers = { 3, 6, 8, 2, 5, 9, 1 };
            int max = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (max < numbers[i]) // Söker igenom int[] från pos. 0 och uppåt för att kontrollera om värdet är högre än nuvarande max
                    max = numbers[i]; // om så är fallet så sparas det nya högre nummret till max.
            }

            return max; // Retunerar max, som är det högsta nummret i array numbers.
        }

        static int SekventiellSök(int[] data, int värde) // Lämplig att använda när du har OSORTERAD data.
        {
            if (data == null)
                return -1; // Kontroll så att funktionen inte kallats utan data.

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == värde)
                {
                    return i; // Söker igenom int[] från pos. 0 och uppåt för att kontrollera om värdet matchar i. Om så, retuneras i som talar om index.
                }
            }
            return -1; // Finns inte värdet i vår int[] så retuneras -1 för att indekera ingen matchning.
        }            

        static int BinärSök(int[] data, int value) // Lämplig att använda nä du har SORTERAD data.
        {
            if (data == null)
                return -1;

            int start = 0;
            int stop = data.Length - 1;

            while (start <= stop)
            {
                int mid = (start + stop) / 2;
                if (data[mid] < value)
                    start = mid + 1;
                else if (data[mid] > value)
                    stop = mid - 1;
                else
                    return mid;
            }

            return -1;
        }


    }
}
