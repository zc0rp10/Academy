using System;
using System.Collections.Generic;
using System.Text;

namespace ClassInstancesAndConstructors
{
    class Car
    {
        public int NumberOfDoors { get; set; }
        public string Make { get; set; }
        public string Brand { get; set; }
        public string TypeOfFule { get; set; }
        public int YearOfManufacture { get; set; }
        public string LicenseNumber { get; set; }

        int currentSpeed;

        public void IncreaseCurrentSpeed(int increase)
        {
            currentSpeed += increase;
            
        }
    }
}
