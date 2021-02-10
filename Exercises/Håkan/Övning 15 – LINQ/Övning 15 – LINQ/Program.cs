using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Globalization;

namespace Övning_15___LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileContent = LoadFile();
            List<Person> names = BuildList(fileContent);

            ListAllAnd(names);
            ListAll23Juli(names);
            ListAllPAndApril(names);
            ListAllLongHairedDogOwners(names);
            ListByInputName(names);
            ListAllByInputDate(names);
            GroupByNameStart(names);
            NameDayByMonth(names);
            NameDayByQuarter(names);
            TopFiveDays(names);
        }

        private static void TopFiveDays(List<Person> names)
        {
            Console.WriteLine();
            Console.WriteLine("De fem dagar på året som flest har namnsdag");
            Console.WriteLine("===================================");
            Console.WriteLine();
            var q = names
                .GroupBy(p => (p.NameDay))
                .OrderByDescending(g => g.Count())
                .Take(5);

            foreach (var item in q)
            {
                Console.WriteLine($"Day: {item.Key:dd MMMM}, Count: {item.Count()}");
            }
        }

        private static void NameDayByQuarter(List<Person> names)
        {
            Console.WriteLine();
            Console.WriteLine("Beräkna hur många som har namnsdag för varje kvartal.");
            Console.WriteLine("===================================");
            Console.WriteLine();
            var q = names
                .GroupBy(p => (p.NameDay.Month - 1) / 3)
                .OrderBy(x => x.Key);

            foreach (var item in q)
            {
                Console.WriteLine($"Q{item.Key + 1}: {item.Count()}");
            }
        }

        private static void NameDayByMonth(List<Person> names)
        {
            Console.WriteLine();
            Console.WriteLine("Beräkna hur många som har namnsdag för varje månad.");
            Console.WriteLine("===================================");
            Console.WriteLine();
            var q = names
                .GroupBy(p => p.NameDay.Month)
                .OrderBy(x => x.Key);

            foreach (var item in q)
            {
                var month = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(item.Key);

                Console.WriteLine($"{month}: {item.Count()}");
            }
        }

        private static void GroupByNameStart(List<Person> names)
        {
            Console.WriteLine();
            Console.WriteLine("Lista hur många namn som börjar på varje bokstav");
            Console.WriteLine("===================================");
            Console.WriteLine();
            var q = names.GroupBy(p => p.Name[0]);
            int total = 0;

            foreach (var item in q)
            {
                Console.WriteLine($"{item.Key}: {item.Count()}");
                total += item.Count();
            }

            Console.WriteLine("Total: " + total);
        }

        private static void ListAllByInputDate(List<Person> names)
        {
            Console.WriteLine();
            Console.WriteLine("Ta emot en inmatning för datum, lista alla som har namnsdag detta datum.");
            Console.WriteLine("===================================");
            Console.WriteLine();
            Console.Write("Enter a date (dd mmm yyyy): ");
            var input = Console.ReadLine();

            var q = names.Where(p => p.NameDay == DateTime.Parse(input));

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
        }

        private static void ListByInputName(List<Person> names)
        {
            Console.WriteLine();
            Console.WriteLine("Ta emot en inmatning för Namn, lista alla namn som matchar");
            Console.WriteLine("===================================");
            Console.WriteLine();
            Console.Write("Enter a name: ");
            var input = Console.ReadLine();

            var q = names.Where(p => p.Name.ToLower() == input.ToLower());
            
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
        }

        private static void ListAllPAndApril(List<Person> names)
        {          
            Console.WriteLine();
            Console.WriteLine("Lista alla namn som börjar på ”P” och har namnsdag i april");
            Console.WriteLine("===================================");

            var q = names.Where(p => p.Name[0] == 'P' && p.NameDay.Month == 4);
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
        }

        private static void ListAll23Juli(List<Person> names)
        {
            Console.WriteLine();
            Console.WriteLine("Lista alla namn som har namnsdag 23 juli");
            Console.WriteLine("========================================");

            var q = names.Where(p => p.NameDay.Day == 23 && p.NameDay.Month == 7);
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
        }

        private static void ListAllAnd(List<Person> names)
        {
            Console.WriteLine("Lista alla namn som börjar på ”And”");
            Console.WriteLine("==========================================================");
            
            var q = names.Where(p => p.Name.StartsWith("And"));
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
        }

        private static List<Person> BuildList(string[] lines)
        {
            var list = new List<Person>();

            foreach (var line in lines)
            {
                var entries = line.Split(";");
                var p = new Person(entries[0], DateTime.Parse(entries[1]));

                if (!list.Contains(p, p))
                    list.Add(p);
            }

            return list;
        }

        static string[] LoadFile()
        {
            return File.ReadAllLines("names.csv", System.Text.Encoding.UTF7);
        }



























        private static void ListAllLongHairedDogOwners(List<Person> names)
        {
            Console.WriteLine();
            Console.WriteLine("Lista alla namn vars hund är långhårig");
            Console.WriteLine("======================================");
            Console.WriteLine("Trollololol!");
        }
    }
}
