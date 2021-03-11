using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagmentSystem.Web.Validation
{
    public class EmailAcmeAttribute : ValidationAttribute
    {
        readonly string correctValue;

        public EmailAcmeAttribute(string correctValue)
        {
            this.correctValue = correctValue;
        }

        public override bool IsValid(object value)
        {
            if (value == null) return false;
            return value.ToString().Contains(correctValue);
        }
    }
}
