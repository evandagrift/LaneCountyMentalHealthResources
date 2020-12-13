using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaneCountyMentalHealth.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult FeedBack()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
