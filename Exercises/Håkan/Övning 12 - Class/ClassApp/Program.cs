using bflibcs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ClassApp
{
    class Program
    {
        static List<Person> kontaktLista = new List<Person>();
        static string filePath = "C:\\temp\\contacts.csv";

        static void Main(string[] args)
        {
            if (File.Exists(filePath))
            {
                Load();
            }
            else
            {

                kontaktLista.AddRange(new List<Person>
                {
                    new Person("Per", "123", "a@a.com"),
                    new Person("Sven", "123", "a@a.com"),
                    new Person("Kalle", "123", "a@a.com"),
                    new Person("Per", "123", "a@a.com"),
                    new Person("Nisse", "123", "a@a.com")
                });

                var add1 = new Address("211B Baker Street, NW1 6XE, London, England");
                var add2 = new Address("600 Pennsylvania Avenue, Washington DC, USA");
                kontaktLista[1].Addresses.Add(add1);
                kontaktLista[1].Addresses.Add(add2);
            }
            //AddPerson();
            //RemovePerson();
            //SortList();
            //Edit();

            foreach (var item in kontaktLista)
            {
                Console.WriteLine(item.FirstName);
                if (item.Addresses != null)
                {
                    foreach (var address in item.Addresses)
                    {
                        Console.WriteLine(address.FullAddress);
                    }
                }
            }

            Save();

        }

        private static void Load()
        {
            List<string> lines = File.ReadAllLines(filePath).ToList();
            foreach (var line in lines)
            {
                string[] entries = line.Split(";");
                if (entries.Length == 3)
                    kontaktLista.Add(new Person(entries[0], entries[1], entries[2])); //Order: Name, pNbr, email
                else
                {
                    var tmp = new List<Address>();
                    for (int i = 3; i < entries.Length; i++)
                    {
                        tmp.Add(new Address(entries[i]));
                    }
                    kontaktLista.Add(new Person(entries[0], entries[1], entries[2], tmp)); //Order: Name, pNbr, email
                }
            }
        }


        private static void Save()
        {

            List<string> output = new List<string>();
            foreach (var item in kontaktLista)
            {
                var sb = new StringBuilder();
                sb.Append($"{item.FirstName};{item.PhoneNumber};{item.Email}");
                if (item.Addresses.Count > 0)
                {
                    for (int i = 0; i < item.Addresses.Count; i++)
                    {
                        sb.Append($";{item.Addresses[i].FullAddress}");
                    }
                }

                output.Add(sb.ToString());
            }

            File.WriteAllLines(filePath, output);
        }

        private static void Edit()
        {
            for (int i = 0; i < kontaktLista.Count - 1; i++)
            {
                Console.WriteLine($"{i + 1}. {kontaktLista[i].FirstName}");
            }
            int index = ConsoleExt.GetInt("Enter the nbr for the contact you'd like to edit: ");
            kontaktLista.RemoveAt(index - 1);
            Console.WriteLine("Enter the updated information for your contact.");
            AddPerson();
        }

        private static void SortList()
        {
            kontaktLista = kontaktLista.OrderBy(c => c.FirstName).ToList();
        }

        private static void RemovePerson()
        {
            Console.Write("Enter first name of the person that you would like to remove: ");
            var name = Console.ReadLine();
            kontaktLista.RemoveAll(y => y.FirstName == name);
        }



        private static void AddPerson()
        {
            Console.Write("Enter first name: ");
            var name = Console.ReadLine();
            Console.Write("Enter phone number: ");
            var phoneNumber = Console.ReadLine();
            Console.Write("Enter e-mail address: ");
            var email = Console.ReadLine();
            kontaktLista.Add(new Person(name, phoneNumber, email));
        }
    }
}
