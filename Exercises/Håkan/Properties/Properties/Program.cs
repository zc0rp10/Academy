using System;

namespace Properties
{
    class Program
    {

        static void Main(string[] args)
        {
            var carArray = new Car[100];

            bool isDone = false; ;
            int arrPos = 0;
            while (!isDone)
            {
                Console.Clear();
                carArray[arrPos] = AddCar();
                arrPos++;
                Console.Write("Would you like to enter anouther car into the database (Y/N): ");
                isDone = Console.ReadKey(true).Key == ConsoleKey.Y  ? false : true; 
            }

            for (int i = 0; i < arrPos; i++)
            {
                Console.WriteLine($"License Plate: {carArray[i].GetLicenseNumber()}, Colour: {carArray[i].GetColor()}");
            }
        }

        private static Car AddCar()
        {
            var newCar = new Car();
            Console.WriteLine("Enter license plate number: ");
            newCar.SetLicenseNumber(Console.ReadLine());
            Console.WriteLine("Enter a car colour (red, green, blue or yellow: ");
            newCar.SetColor(Console.ReadLine());
            return newCar;
        }
    }
}
