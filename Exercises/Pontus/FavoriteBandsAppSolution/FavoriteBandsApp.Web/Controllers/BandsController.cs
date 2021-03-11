using FavoriteBandsApp.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FavoriteBandsApp.Web.Controllers
{
    public class BandsController : Controller
    {
        BandService service = new BandService();
        [Route("")]
        [Route("bands")]
        public IActionResult Index()
        {
            var bands = service.GetAllBands();
            return View(bands);
        }

        [Route("bands/{id}")]
        public IActionResult Details(int id)
        {
            var band = service.GetBandById(id);
            return View(band);
            //return Content($"Här visar vi produkt {band.Name}");
        }
    }
}
