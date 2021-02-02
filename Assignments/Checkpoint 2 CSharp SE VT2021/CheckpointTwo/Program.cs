using System;

namespace CheckpointTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] personArr = new Person[6]
            {
                new Person("Bo", "Andersson", 45),
                new Person("Li","Johansson", 34),
                new Person("An","Pettersson", 43),
                new Person("Io","Johansson", 66),
                new Person("El","Karlsson", 20),
                new Person("Lo","Pettersson", 55),
            };

            Console.WriteLine("+++++ Age Calculator +++++");
            //Console.WriteLine("Average Age is: " + AverageAge(personArr, "Pettersson"));
            //Console.WriteLine("Median Age is " + MedianAge(personArr, "Pettersson"));
            Console.WriteLine(MedianAge2(personArr, "Pettersson"));
        }

        static double MedianAge2(Person[] arr, string value)
        {
            int[] newArr = new int[arr.Length];
            int validEntries = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].LastName.ToLower() != value.ToLower())
                {
                    newArr[i] = arr[i].Age;
                    validEntries++;
                }
            }

            if (validEntries > 0)
            {
                Array.Sort(newArr);

                int adjust = newArr.Length - validEntries;
                int size = newArr.Length - adjust;
                int mid = (size / 2) + adjust;

                double median = (size % 2 != 0) ? (double)newArr[mid] : (double)(newArr[mid] + newArr[mid - 1]) / 2;

                return median;
            }
            else
                return 0.0;
        }

        static double MedianAge(Person[] arr, string value)
        {
            int[] tmpArr = new int[arr.Length];
            int newArrLength = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].LastName.ToLower() != value.ToLower())
                {
                    tmpArr[i] = arr[i].Age;
                    newArrLength++;
                }
            }
            Array.Sort(tmpArr);

            int[] newArr = new int[newArrLength];

            for (int i = 0; i < newArrLength; i++)
            {
                newArr[i] = tmpArr[i + tmpArr.Length - newArrLength];
            }

            int size = newArr.Length;
            int mid = size / 2;
            double median = (size % 2 != 0) ? (double)newArr[mid] : (double)(newArr[mid] + newArr[mid - 1]) / 2;

            return median;
        }

        static double AverageAge(Person[] arr, string value)
        {
            double a = 0;
            int b = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].LastName.ToLower() != value.ToLower())
                {
                    a += arr[i].Age;
                    b++;
                }
            }
            return a / b;
        }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private int age;

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0 && value < 126) // Accepts a value between 1 and 125.
                    age = value;
                else
                    throw new Exception("Age must be in the range of 1 to 125.");
            }
        }


    }
}
