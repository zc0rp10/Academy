using System;
using System.Collections.Generic;

namespace Assessment.Hotels.Core
{
    public class Hotel
    {
        public Hotel(string name, int nbrOfPools)
        {
            Name = name;
            NbrOfPools = nbrOfPools;
            HotelSuits = new List<Suits>();
        }

        public string Name { get; set; }
        public int NbrOfPools { get; set; }
        public List<Suits> HotelSuits { get; set; }

        public string Description
        {
            get { return $"{Name} has {NbrOfPools} pools"; }
        }


        public void SuitsGroup(string suitType)
        {
            Suits newSuitType = (Suits)Enum.Parse(typeof(Suits), suitType);
            bool isExisting = Suits(newSuitType);
            if (isExisting)
                throw new ArgumentException();
            else
                HotelSuits.Add(newSuitType);
        }

        public bool Suits(Suits type)
        {
            return HotelSuits.Contains(type);
        }
    }
}
