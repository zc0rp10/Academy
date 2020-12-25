using System;
using System.Collections.Generic;
using System.Text;

namespace Properties
{
    class Person
    {
        private int age; //propfull Full Property, use when you NEED to validate on get or set.
        
        public int Age
        {
            get { return age; }
            set {
                if (value < 0)
                    age = 0;
                else
                    age = value; }
        }

        public string Name { get; private set; } //prop Automatic Proerty, use when you DON'T need to validate assignments.
                                                 //You can add private to set if you want the prop to only be set up from constructor, and not changed later.

        public Person(int age, string name)
        {
            Age = age;
            Name = name;
        }
    }
}
