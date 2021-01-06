using System;

namespace LibCargoShip
{
    public class Ship
    {
        // Constant Values
        const int CYCLE_WEIGHT = 3;
        const int CAR_WEIGHT = 5;
        const int TRUCK_WEIGHT = 11;
        const int TRAIN_WEIGHT = 17;
        const int MAX_WEIGHT = 10;

        // Class Props
        public int Capacity { get; set; }
        public int CycleCount { get; set; }
        public int CarCount { get; set; }
        public int TruckCount { get; set; }
        public int TrainCarCount { get; set; }

        Random random = new Random();

        // Constructor - Called when a new instance (object) of a class is created.
        public Ship()
        {
            CycleCount = 0;
            CarCount = 0;
            TruckCount = 0;
            TrainCarCount = 0;

            // Creates a ship with a random capacity.
            Capacity = random.Next(MAX_WEIGHT) * CYCLE_WEIGHT + random.Next(MAX_WEIGHT) * CAR_WEIGHT + random.Next(MAX_WEIGHT) *
                TRUCK_WEIGHT + random.Next(MAX_WEIGHT) * TRAIN_WEIGHT;
        }

        // Methods
        public int GetShipLoad()
        {
            return CycleCount * CYCLE_WEIGHT + CarCount * CAR_WEIGHT + TruckCount * TRUCK_WEIGHT + TrainCarCount * TRAIN_WEIGHT;
        }

        public int OverUnder()
        {
            return Capacity - GetShipLoad();
        }

        public override string ToString()
        {
            return $"Capacity = {Capacity}, Current Load = {GetShipLoad()}";
        }
    }
}
