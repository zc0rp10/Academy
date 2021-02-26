using System;
using System.Collections.Generic;
using System.Linq;

namespace Assessment.Hotels.Core
{
    public class Destination
    {
        public string Name { get; set; }
        public List<Hotel> Hotels { get; set; }

        public Destination(string name)
        {
            Name = name;
            Hotels = new List<Hotel>();
        }

        public void AddHotel(string hotelName, int nbrOfPools)
        {
            var hotel = new Hotel(hotelName, nbrOfPools);
            Hotels.Add(hotel);
        }

        public int TotalNumberOfPools()
        {
            int totalPools = 0;

            foreach (var hotel in Hotels)
            {
                totalPools += hotel.NbrOfPools;
            }

            return totalPools;
        }

        public int TotalNumberOfPools_Linq()
        {
            return Hotels.Sum(h => h.NbrOfPools);
        }

        public string GetName()
        {
            return $"DESTINATION {Name}".ToUpper();
        }

        public List<String> HotelNames()
        {
            var hotelNames = new List<String>();
            foreach (var hotel in Hotels)
            {
                hotelNames.Add(hotel.Name);
            }

            return hotelNames;
        }

        public List<String> HotelNames_Linq()
        {
            return Hotels
                .Select(h => h.Name)
                .ToList();
        }
        
        public int MaxPools()
        {
            int max = 0;
            
            foreach (var hotel in Hotels)
            {
                if (hotel.NbrOfPools > max)
                    max = hotel.NbrOfPools;
            }

            return max;
        }
        public int MaxPools_Linq()
        {
            return Hotels.Max(h => h.NbrOfPools);
        }
    }
}
