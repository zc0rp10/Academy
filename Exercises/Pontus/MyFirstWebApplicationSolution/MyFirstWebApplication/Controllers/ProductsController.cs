using Microsoft.AspNetCore.Mvc;
using MyFirstWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebApplication.Controllers
{
    public class ProductsController : Controller
    {
        ProductService service = new ProductService();

        // En Action - Svarar på ett  HTTP anrop
        [Route("")]
        public IActionResult Index()
        {
            //return View();
            var products = service.GetAll();
            return View(products);
        }

        [Route("products/create")]
        public IActionResult Create()
        {
            return View();
            //return Content("Här visar vi ett formulär för att skapa en ny produkter");
        }

        [Route("products/{id}")]
        public IActionResult Details(int id)
        {
            //return View();
            return Content($"Här visar vi produkt {id}");
        }

    }
}
