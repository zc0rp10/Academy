using System.Collections.Generic;
using System.Linq;

namespace _4_TempClassVar
{
    class City
    {
        public static string coldTown, warmTown;
        static double minTemp, maxTemp;
        static bool firstTown = true;
        public static List<double> tempList = new List<double>();

        public string Name { get; set; }
        public double Temperature { get; set; }

        public City(string name, double temperature)
        {
            Name = name;
            Temperature = temperature;
            HighestTemp();
            LowestTemp();
            tempList.Add(temperature);
        }

        void HighestTemp()
        {
            if (firstTown || Temperature > maxTemp)
            {
                maxTemp = Temperature;
                warmTown = Name;
            }
        }

        void LowestTemp()
        {
            if (firstTown || Temperature < minTemp)
            {
                minTemp = Temperature;
                coldTown = Name;
            }
            firstTown = false;
        }

        public static double MeanTemp()
        {
            return tempList.Average();
        }
    }
}