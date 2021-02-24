using System;
using System.Collections.Generic;
using System.Linq;

namespace Assessment.Core
{
    public class Country
    {
        public Country(string name)
        {
            Name = name;
            SkiResorts = new List<SkiResort>();
        }

        public string Name { get; set; }
        public List<SkiResort> SkiResorts { get; set; }

        public void AddSkiResort(string location, int nbrOfLifts)
        {
            SkiResorts.Add(new SkiResort(location, nbrOfLifts));
        }

        public int TotalNumberOfLifts()
        {
            int totalNumberOfLifts = 0;
            foreach (var item in SkiResorts)
            {
                totalNumberOfLifts += item.NumberOfLifts;
            }

            return totalNumberOfLifts;
        }

        public int TotalNumberOfLifts_Linq()
        {
            return SkiResorts.Sum(s => s.NumberOfLifts);
        }

        public string GetName()
        {
            return $"COUNTRY {Name.ToUpper()}";
        }

        public List<string> SkiResortNames()
        {
            var SkiResortNames = new List<String>();
            foreach (var item in SkiResorts)
            {
                SkiResortNames.Add(item.Name);
            }

            return SkiResortNames;
        }

        public List<string> SkiResortNames_Linq()
        {
            return SkiResorts.Select(s => s.Name).ToList();
        }

        public int MaxLifts()
        {
            int max = 0;
            foreach (var item in SkiResorts)
            {
                if (item.NumberOfLifts > max)
                    max = item.NumberOfLifts;
            }

            return max;
        }

        public int MaxLifts_Linq()
        {
            return SkiResorts.Max(s => s.NumberOfLifts);
        }
    }
}
