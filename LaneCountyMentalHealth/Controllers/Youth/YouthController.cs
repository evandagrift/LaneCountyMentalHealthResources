using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaneCountyMentalHealth.Controllers
{
    public class YouthController : Controller
    {

        [HttpGet]
        public IActionResult getYouthResources()
        {
            return View();
        }


        [HttpPost]
        public IActionResult displayYouthResources()
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
