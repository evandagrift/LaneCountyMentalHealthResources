using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaneCountyMentalHealth.Controllers.YoungAdult.Mental
{
    public class YoungAdultMentalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
