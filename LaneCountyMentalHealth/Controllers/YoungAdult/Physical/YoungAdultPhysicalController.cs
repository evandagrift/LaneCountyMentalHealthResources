using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaneCountyMentalHealth.Controllers.YoungAdult.Physical
{
    public class YoungAdultPhysicalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
