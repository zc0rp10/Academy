using System;

namespace PreAssignmentNbrOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Bo";
            int age = 30;

            PrintOut(name, age);
        }

        private static bool PrintOut(string name, int age)
        {
            Console.WriteLine($"Name: {name}, Age: {age}");

            if (age > 25)
                return true;
            else
                return false;
        }
    }
}
