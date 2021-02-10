﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Delegater06
{
    class Person : IEqualityComparer<Person>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; private set; }
        public int Age => DateTime.Now.Year - BirthYear;
        public Person(string firstName, string lastName, int birthYear)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthYear = birthYear;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {BirthYear} {Age}";
        }

        public bool Equals([AllowNull] Person x, [AllowNull] Person y)
        {
            return x.Age == y.Age && x.FirstName == y.FirstName && x.LastName == y.LastName;
        }

        public int GetHashCode([DisallowNull] Person obj)
        {
            return $"{obj.FirstName}{obj.LastName}{obj.Age}".GetHashCode();
        }
    }

}
