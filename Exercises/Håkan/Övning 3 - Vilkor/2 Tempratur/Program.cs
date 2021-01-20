using System;

namespace _2_Tempratur
{
    class Program
    {
        static void Main(string[] args)
        {

            double tmpSve = GetTemp("Svedala");
            double tmpJuk = GetTemp("Jukkasjärvi");

            if (tmpSve < tmpJuk)
                Console.WriteLine("Det är kallast i Svedala.");
            else if (tmpJuk < tmpSve)
                Console.WriteLine("Det är kallast i Jukkasjärvi.");
            else if (tmpJuk == tmpSve)
                Console.WriteLine("Det är lika kallt.");
        }

        private static double GetTemp(string ort)
        {
            double num;
            bool isValid;
            do
            {
                Console.Write($"Vad är tempraturen i {ort}?: ");
                string input = Console.ReadLine();
                isValid = double.TryParse(input, out num);
            } while (!isValid);
            return num;
        }
    }
}
