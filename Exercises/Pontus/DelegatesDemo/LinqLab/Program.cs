using System;
using System.Collections.Generic;
using System.Linq;


namespace LinqLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new[]
            {
                new Person { Name = "Bo", Age = 20, WorkplaceId = 1},
                new Person { Name = "Li", Age = 31, WorkplaceId = 1},
                new Person { Name = "An", Age = 40, WorkplaceId = 2}
            };

            var workPlaces = new[]
            {
                new Workplace { CompanyName = "ICA", WorkplaceId = 1 },
                new Workplace { CompanyName = "Coop", WorkplaceId = 2 }
            };

            //Name30Plus(people);
            //NbrOfBelow30(people);
            //PeopleAverageAge(people);
            //FirstOfName(people);
            //PeopleAndWorkplace(people, workPlaces);
            //WorkplaceEmployeeCount(people, workPlaces);

            people.Print(p => p.Name);
            workPlaces.Print(w => w.WorkplaceId);

           // Console.WriteLine(SomeMethod(people[1]));                      
        }

        static object Predicate(Person p)
        {
            return p.Name;
        }

        private static void FirstOfName(Person[] people)
        {
            Console.WriteLine();
            Console.WriteLine("Första personen med ett visst namn (if exists)");
            Console.WriteLine("=======================================");

            var q = people
                .FirstOrDefault(p => p.Name == "Bo");

            Console.WriteLine(q);
        }

        private static void WorkplaceEmployeeCount(Person[] people, Workplace[] workPlaces)
        {
            Console.WriteLine();
            Console.WriteLine("Namn på workplace och antal anställda");
            Console.WriteLine("=======================================");
            var q = workPlaces
                .GroupJoin(people, p => p.WorkplaceId, w => w.WorkplaceId, (w, emps) => new
                {
                    Company = w.CompanyName,
                    Employees = emps.Count()
                }) ;

            foreach (var item in q)
            {
                Console.WriteLine($"{item.Company} har {item.Employees} anställda.");
            }
        }

        private static void PeopleAndWorkplace(Person[] people, Workplace[] workPlaces)
        {
            Console.WriteLine();
            Console.WriteLine("Namn på personer och deras arbetsplats");
            Console.WriteLine("=======================================");
            var q = workPlaces
                .Join(people, w => w.WorkplaceId, p => p.WorkplaceId, (w, p) => new
                {
                    Company = w.CompanyName,
                    Employee = p.Name
                });

            foreach (var item in q)
            {
                Console.WriteLine($"{item.Employee} jobbar på {item.Company}");
            }
        }

        private static void PeopleAverageAge(Person[] people)
        {
            Console.WriteLine();
            Console.WriteLine("Personernas Snittålder");
            Console.WriteLine("=======================================");
            var q = people
                .Average(p => p.Age);
                
           
            Console.WriteLine(q);
        }

        private static void NbrOfBelow30(Person[] people)
        {
            Console.WriteLine();
            Console.WriteLine("Antal personer under 30.");
            Console.WriteLine("=======================================");
            //var q = people
            //    .Where(p => p.Age < 30)
            //    .Count();

            var q = people
                .Count(p => p.Age < 30); // Bättre

            Console.WriteLine(q);
        }
        
        private static void Name30Plus(Person[] people)
        {
            Console.WriteLine();
            Console.WriteLine("Namn på alla över 30, sort by name, age");
            Console.WriteLine("=======================================");
            var q = people
                .Where(p => p.Age > 30)
                .OrderBy(p => p.Name)
                .ThenBy(p => p.Age)
                .Select(p => p.Name);

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
        }

        
    }
}
