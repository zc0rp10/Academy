using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagmentSystem.Web.Models
{
    public class EmployeeService
    {
        static readonly List<Employee> Employees = new();
        static int EmpListCount = 1;

        public void AddEmployee(Employee emp)
        {
            emp.Id = EmpListCount++;
            Employees.Add(emp);
        }

        public void EditEmployee(Employee updatedEmp)
        {
            var emp = Employees.FirstOrDefault(e => e.Id == updatedEmp.Id);
            emp.FirstName = updatedEmp.FirstName;
            emp.LastName = updatedEmp.LastName;
            emp.EMail = updatedEmp.EMail;
        }

        public Employee[] GetAllEmployees()
        {
            return Employees.ToArray();
        }

        public Employee GetEmployeeById(int id)
        {
            var emp = Employees.FirstOrDefault(e => e.Id == id);
            return emp;
        }

        public void DeleteEmployeeById(int id)
        {
            Employees.Remove(Employees.FirstOrDefault(d => d.Id == id));
        }
    }
}
