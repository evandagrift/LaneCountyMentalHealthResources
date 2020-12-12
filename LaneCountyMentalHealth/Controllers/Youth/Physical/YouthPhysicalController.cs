using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaneCountyMentalHealth.Controllers.Youth
{
    public class YouthPhysicalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
