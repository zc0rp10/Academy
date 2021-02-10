using System;
using System.Collections.Generic;

namespace ClassLibraryProject
{
    public class Person
    {
        public Person(string firstName, string lastName, bool isDeveloper, Continent location)
        {
            FirstName = firstName;
            LastName = lastName;
            FullName = firstName + " " + lastName;
            IsSystemDeveloper = isDeveloper;
            Continent = location;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public bool IsSystemDeveloper { get; set; }
        public Continent Continent { get; set; }
        private int health = 100;
        public int Health
        {
            get { return health; }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentOutOfRangeException("Health");
                else
                    health = value;
            }
        }
        public int LengthOfFirstNameAndLastName { get { return FirstName.Length + LastName.Length; } }
        public List<string> Inventory { get; set; } = new List<string> { "Wrist Watch" };

        public string GetPresentation()
        {
            return $"{FirstName} {LastName} is from the continent of {Continent} and is{(IsSystemDeveloper ? "" : "n't")} a system developer.";
        }
    }
}
