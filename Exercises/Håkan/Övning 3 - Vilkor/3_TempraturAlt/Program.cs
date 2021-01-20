using System;
using System.Collections.Generic;
using System.Linq;

namespace _3_TempraturAlt
{
    class Program
    {
        static void Main(string[] args)
        {
            double tmpSve = GetTemp("Svedala");
            double tmpJuk = GetTemp("Jukkasjärvi");
            double tmpVis = GetTemp("Visby");

            if (tmpSve > tmpJuk && tmpSve > tmpVis)
                Console.WriteLine("Det är kallast i Svedala.");
            else if (tmpJuk > tmpSve && tmpSve > tmpVis)
                Console.WriteLine("Det är kallast i Jukkasjärvi.");
            else
                Console.WriteLine("Det är varmast i Visby.");

            double avg = CalculateMean(tmpSve, tmpJuk, tmpVis);
            Console.WriteLine($"Medeltemperatur är {avg} grader.");
        }

        static double CalculateMean(double num1, double num2, double num3)
        {
            return (num1 + num2 + num3) / 3;
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
