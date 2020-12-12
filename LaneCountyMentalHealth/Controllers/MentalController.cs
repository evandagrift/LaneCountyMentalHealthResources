using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaneCountyMentalHealth.Controllers
{
    public class MentalController : Controller
    {
        [HttpGet]
        public IActionResult getYoungAdultResources()
        {
            return View();
        }

        [HttpPost]
        public IActionResult displayYoungAdultResources()
        {
            return View();
        }

        public IActionResult Physical()
        {
            return View();
        }

        public IActionResult Mental()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
