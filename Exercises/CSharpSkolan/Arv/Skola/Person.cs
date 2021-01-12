using System;
using System.Collections.Generic;
using System.Text;

namespace Arv
{
    class Person
    {
        private string name;
        private string telephone;

        public Person(string name, string telephone)
        {
            this.name = name;
            this.telephone = telephone;
        }

        public string GetName()
        {
            return name;
        }

        public string GetTelephone()
        {
            return telephone;
        }
    }
}
