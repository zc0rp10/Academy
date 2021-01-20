using System;

namespace _4_TempClassVar
{
    class Program
    {
        static void Main(string[] args)
        {
            var visby = new City("Visby", 2);
            var svedala = new City("Svedala", 5);
            var jukkasjärvi = new City("Jukkasjärvi", 18);

            Console.WriteLine("Varmast är " + City.warmTown);
            Console.WriteLine("Kallast är " + City.coldTown);
            Console.WriteLine($"Medeltempraturen är : {City.MeanTemp()}c");
        }
    }
}
