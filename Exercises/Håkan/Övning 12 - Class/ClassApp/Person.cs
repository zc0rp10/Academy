using System;
using System.Collections.Generic;
using System.Text;

namespace ClassApp
{
    class Person
    {
        public Person(string firstName, string phoneNumber, string email)
        {
            Addresses = new List<Address>();
            FirstName = firstName;
            PhoneNumber = phoneNumber;
            Email = email;
           
        }

        public Person(string firstName, string phoneNumber, string email, List<Address> addresses)
        {
            Addresses = new List<Address>();
            FirstName = firstName;
            PhoneNumber = phoneNumber;
            Email = email;
            Addresses = addresses;
        }

        public string FirstName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public List<Address> Addresses { get; set; }
    }
}
