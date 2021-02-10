using System;
using System.Collections.Generic;
using System.Text;

namespace LinqLab
{
    class Workplace
    {
        public int WorkplaceId { get; set; }
        public string CompanyName { get; set; }

        public override string ToString()
        {
            return $"WorkplaceId: {WorkplaceId}\t CompanyName: {CompanyName}";
        }
    }
}
