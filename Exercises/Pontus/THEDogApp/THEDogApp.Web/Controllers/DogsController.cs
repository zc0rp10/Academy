using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using THEDogApp.Web.Models;

namespace THEDogApp.Web.Controllers
{
    public class DogsController : Controller
    {
        DogsService dogService = new DogsService();

        [Route("")]
        [Route("dogs/")]
        [Route("dogs/index")]
        public IActionResult Index()
        {
            var dogs = dogService.GetAllDogs();
            return View(dogs);
        }

        [Route("dogs/{id}")]
        public IActionResult Details(int id)
        {
            var dog = dogService.GetDogById(id);
            return View(dog);
        }

        [Route("dogs/create")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [Route("dogs/create")]
        [HttpPost]
        public IActionResult Create(Dog dog)
        {
            dogService.AddDog(dog);
            return RedirectToAction(nameof(Index));
        }

        [Route("dogs/edit/{id}")]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var dog = dogService.GetDogById(id);
            return View(dog);
        }

        [Route("dogs/edit/{id}")]
        [HttpPost]
        public IActionResult Edit(Dog dog)
        {
            dogService.EditDog(dog);
            return RedirectToAction(nameof(Index));
        }

        [Route("dogs/delete/{id}")]
        public IActionResult Delete(int id)
        {
            dogService.DeleteDog(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
