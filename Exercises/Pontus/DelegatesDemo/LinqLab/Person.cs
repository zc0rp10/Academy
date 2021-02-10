using System;
using System.Collections.Generic;
using System.Text;


namespace LinqLab
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int WorkplaceId { get; set; }


        public override string ToString()
        {
            return $"Name: {Name}\t Age: {Age}\t WorkplaceId: {WorkplaceId}";
        }
    }
}
