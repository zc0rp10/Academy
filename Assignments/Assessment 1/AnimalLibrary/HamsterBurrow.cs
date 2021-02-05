using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalLibrary
{
    public class HamsterBurrow // Sv. Hamsterhåla/gryt
    {
        public HamsterBurrow(double longitude, double latitude)
        {
            Longitude = longitude;
            Latitude = latitude;
        }

        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}
