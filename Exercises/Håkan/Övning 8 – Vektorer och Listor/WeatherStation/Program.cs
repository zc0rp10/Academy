using System;
using bflibcs;

namespace WeatherStation
{
    /* 3.   Skapa en console app som tar in data från en väderstation.Programmet ska fråga hur många
     *      mätningar som har gjorts. Programmet ska sedan fråga efter mätdata, och skriva ut medeltemperaturen.*/
    class Program
    {
        static void Main(string[] args)
        {
            int nbrOfM = ConsoleExt.GetInt("Enter the number of measurements taken: ");
            int[] measurements = GetMeasurmentDetails(nbrOfM);

            int sum = GetSum(measurements);
            float average = (float)sum / nbrOfM;

            Console.WriteLine($"The average temperature is: {average:f2} degrees.");

        }

        private static int GetSum(int[] measurements)
        {
            int sum = 0;

            for (int i = 0; i < measurements.Length; i++)
            {
                sum = sum + measurements[i];
            }

            return sum;
        }

        private static int[] GetMeasurmentDetails(int nbrOfM)
        {
            int[] measurements = new int[nbrOfM];
            for (int i = 0; i < nbrOfM; i++)
            {
                measurements[i] = ConsoleExt.GetInt($"What was the result of measurment nbr {i + 1}: ");
            }

            return measurements;
        }
    }
}
