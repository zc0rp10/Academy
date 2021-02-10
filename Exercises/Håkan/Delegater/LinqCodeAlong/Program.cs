using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqCodeAlong
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

            //var q = people.Where(p => p.BirthYear < 1900);

            //var averageAge = people
            //    .Where(p => p.BirthYear > 1900 && p.BirthYear < 2000)
            //    .Average(p => p.Age);

            //var johansson = people
            //    .Where(p => p.LastName == "Johansson");

            //var HundreadOrGreater = people
            //    .Where(p => p.Age > 100 && p.LastName[0] != 'B')
            //    .OrderBy(p => p.FirstName);

            //var over100 = people
            //    .Where(p => p.BirthYear >= 1900 && p.BirthYear < 2000)
            //    .OrderBy(p => p.LastName)
            //    .ThenBy(p => p.FirstName)
            //    .ThenBy(p => p.BirthYear);

            var first = people
                .First(p => p.LastName == "Johansson");


            Console.WriteLine(first);





            //foreach (var item in HundreadOrGreater)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
