using System;

namespace _1_BästaLaget
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Är Malmö FF sveriges bästa lag (Ja/Nej)?: ");
            string answer = Console.ReadLine().ToLower();
            if (answer == "ja")
                Console.WriteLine("Va? Fotboll är ju ingen sport... www.shl.se");
            
        }
    }
}
