using EmployeeManagmentSystem.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagmentSystem.Web.Controllers
{
    public class EmployeesController : Controller
    {
        readonly EmployeeService service = new();

        [Route("")]
        [Route("employees/index")]
        public IActionResult Index()
        {
            var empArr = service.GetAllEmployees();
            return View(empArr);
        }

        [Route("employees/create")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [Route("employees/create")]
        [HttpPost]
        public IActionResult Create(Employee emp)
        {

            if (!ModelState.IsValid)
                return View(emp);

            service.AddEmployee(emp);
            return RedirectToAction(nameof(Index));
        }

        [Route("employees/edit/{id}")]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var emp = service.GetEmployeeById(id);
            return View(emp);
        }

        [Route("employees/edit/{id}")]
        [HttpPost]
        public IActionResult Edit(Employee emp)
        {
            if (!ModelState.IsValid)
                return View(emp);

            service.EditEmployee(emp);
            return RedirectToAction(nameof(Index));
        }

        [Route("employees/details/{id}")]
        public IActionResult Details(int id)
        {
            var emp = service.GetEmployeeById(id);
            return View(emp);
        }

        [Route("employees/delete/{id}")]
        public IActionResult Delete(int id)
        {
            service.DeleteEmployeeById(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
