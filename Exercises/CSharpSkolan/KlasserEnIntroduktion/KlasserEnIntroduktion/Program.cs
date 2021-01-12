using System;

namespace KlasserEnIntroduktion
{
    class Program
    {
        static void Main(string[] args)
        {
            InkomstInfo info = new InkomstInfo();
            Console.WriteLine("Ange ditt namn: ");
            info.Namn = Console.ReadLine();
            Console.WriteLine("Ange din inkomst: ");
            info.Inkomst = int.Parse(Console.ReadLine());
            Console.WriteLine("Ange antal timmar: ");
            info.Timmar = int.Parse(Console.ReadLine());

            Console.WriteLine(info.Namn + ", din timlön blev: " + info.Timlön + " kr/h.");
        }
    }
}
