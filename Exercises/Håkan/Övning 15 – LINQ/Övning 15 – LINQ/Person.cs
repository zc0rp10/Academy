using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Diagnostics.CodeAnalysis;

namespace Övning_15___LINQ
{
    class Person : IEqualityComparer<Person>
    {
        public Person(string name, DateTime nameDay)
        {
            Name = name;
            NameDay = nameDay;
        }

        public string Name { get; set; }
        public DateTime NameDay { get; set; }

        public override string ToString()
        {
            return $"{Name} {NameDay:d}";
        }

        public bool Equals([AllowNull] Person x, [AllowNull] Person y)
        {
            return x.Name == y.Name && x.NameDay == y.NameDay;
        }

        public int GetHashCode([DisallowNull] Person obj)
        {
            return $"{obj.Name}{obj.NameDay}".GetHashCode();
        }
    }
}
