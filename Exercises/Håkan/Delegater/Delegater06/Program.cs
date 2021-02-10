using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegater06
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();

            people.Add(new Person("Gustav", "Vasa", 1496));
            people.Add(new Person("Fredrika ", "Bremer", 1801));
            people.Add(new Person("Jane", "Doe", 1967));
            people.Add(new Person("Kenneth", "Johansson", 2009));
            people.Add(new Person("Alfred", "Nobel", 1833));
            people.Add(new Person("Inga-Britt", "Ahlenius", 1939));
            people.Add(new Person("August", "Strindberg", 1849));
            people.Add(new Person("Elin", "Wägner", 1882));
            people.Add(new Person("Nathalie", "Johansson", 2006));
            people.Add(new Person("Ingmar", "Bergman", 1918));
            people.Add(new Person("Eva", "Ekeblad", 1724));
            people.Add(new Person("Lars", "Norén", 1944));
            people.Add(new Person("John", "Doe", 1957));
            people.Add(new Person("Ellen", "Key", 1849));
            people.Add(new Person("Håkan", "Johansson", 1962));
            people.Add(new Person("Pontus", "Wittenmark", 1979));
            people.Add(new Person("Hanna E", "Andersson", 1991));
            people.Add(new Person("Sissel", "Gade", 1992));
            people.Add(new Person("Patrik", "Jönsson", 1976));
            people.Add(new Person("Karin", "Cula", 1957));
            people.Add(new Person("Marilyn", "Johansson", 1976));
            people.Add(new Person("Kalle", "Cula", 1957));


            // var q = people
            //.First(p => p.FirstName.Equals("Yoda")); // Throws exception cuz no hit.

            // var q = people
            //     .FirstOrDefault(p => p.FirstName == "Yoda"); // Better cuz returns null instead.

            var ellen = new Person("Ellen", "Key", 1849);
            var q = people
                //.Select(p => p.FirstName);
                //.Select(p => $"{p.FirstName} {p.LastName}");
                //.Select(p => new PersonMinimized(p.FirstName, p.BirthYear));
                //.Select(p => new { Namn = p.FirstName, Födelseår = p.BirthYear });
                //.SingleOrDefault(p => p.LastName.Equals("Johansson"));
                //.GroupBy(p => p.LastName);
                .Contains(ellen, new Person("Ellen", "Key", 1849));

            Console.WriteLine(q);

            //foreach (var lastName in q)
            //{
            //    Console.WriteLine(lastName.Key);
            //    foreach (var firstName in lastName)
            //    {
            //        Console.WriteLine("\t" + firstName.FirstName);
            //    }
            //}
            //Console.WriteLine(q);
        }
    }

    class PersonMinimized
    {
        public PersonMinimized(string firstName, int birthYear)
        {
            Namn = firstName;
            Födelseår = birthYear;
        }

        public string Namn { get; set; }
        public int Födelseår { get; set; }

        public override string ToString()
        {
            return $"{Namn} {Födelseår}";
        }
    }
}
