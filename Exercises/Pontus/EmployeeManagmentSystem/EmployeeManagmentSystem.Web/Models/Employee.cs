using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagmentSystem.Web.Validation;

namespace EmployeeManagmentSystem.Web.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [EmailAddress]
        [Required]
        [Display(Name = "E-Mail Address")]
        [EmailAcmeAttribute("@acme.com", ErrorMessage = "E-mail domain needs to be @acme.com")]
        public string EMail { get; set; }
    }
}
