using bflibcs;
using System;

namespace FiveNames
{
    /* Skapa en Console Application:
     * 1.   ..som skapar en string-vektor med fem element. Användaren får mata in fem namn via en for-loop.
     *      Programmet skriver sedan ut namnen i en annan for-loop i omvänd ordning.
     * 2.   ... lägg till funktionalitet till lösningen ovan för att byta ut ett namn på ett givet index.
     * 3.   ... som tar in data från en väderstation. Programmet ska fråga hur många mätningar som har gjorts.
     *      Programmet ska sedan fråga efter mätdata, och skriva ut medeltemperaturen.*/
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];
            GetNames(names);
            Console.WriteLine();
            PrintNames(names);

            int index = ConsoleExt.GetInt("Enter a number to replace that name: ");
            Console.Write("Enter a new name: ");
            names[index -1] = Console.ReadLine();

            PrintNames(names);
        }

        private static void PrintNames(string[] names)
        {
            for (int i = names.Length; i --> 0;)
            {
                Console.WriteLine($"{i+1}. {names[i]}");
            }
        }

        private static void GetNames(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Enter name nbr {i+1} of {names.Length}: ");
                names[i] = Console.ReadLine();
            }
        }
    }
}
