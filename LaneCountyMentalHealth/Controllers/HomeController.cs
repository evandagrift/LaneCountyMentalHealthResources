using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LaneCountyMentalHealth.Models;

namespace LaneCountyMentalHealth.Controllers
{
    public class HomeController : Controller
    {
        private readonly SiteContext context;


        public HomeController(SiteContext c)
        {
            context = c;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Generated(HomeForum forum)
        {
            List<Link> returnLinks = new List<Link>();
            List<Link> links = new List<Link>();

            if (context.Links.Count() < 1)
            {
                links = LazySeed();

                context.AddRange(links);
                context.SaveChanges();
                links = new List<Link>();
            }

            returnLinks = context.Links.ToList();

            HomepageModel model = new HomepageModel();
            model.Links = returnLinks;
            //pass model to view
            return View(model);
        }

        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public List<Link> LazySeed()
        {
            List<Link> links = new List<Link>();
            Link l = new Link();

            l.Description = "Looking Glass";
            l.Url = "https://www.lookingglass.us/services/#counseling";
            l.Catagory = "Mental";
            l.SubCatagory = "Youth, Young Adult";

            links.Add(l);


            l = new Link();
            l.Description = "Lane Kids";
            l.Url = "https://www.lanekids.org/10-local-food-resources-for-families-you-might-not-know-about/";
            l.Catagory = "Financial";
            l.SubCatagory = "Youth, Young Adult, Food Insecurity";

            links.Add(l);


            l = new Link();
            l.Description = "Lane Behavioral Health";
            l.Url = "https://lanecounty.org/government/county_departments/health_and_human_services/behavioral_health/child_and_adolescent_mental_health_services";
            l.Catagory = "Mental";
            l.SubCatagory = "Therapy, Mental Health, Teen, Young Adult";

            links.Add(l);


            l = new Link();
            l.Description = "Teen Empowerment";
            l.Url = "https://youthempowerment.com/articles-of-empowerment/";
            l.Catagory = "Mental";
            l.SubCatagory = "Coping Strategies, Mental Health, Suicide Prevention, Teen, Young Adult";

            links.Add(l);


            l = new Link();
            l.Description = "Looking Glass Shelter";
            l.Url = "https://www.lookingglass.us/services/#runaway";
            l.Catagory = "Financial";
            l.SubCatagory = "Teen, Young Adult, Shelter";

            links.Add(l);


            l = new Link();
            l.Description = "Food for Lane County";
            l.Url = "https://foodforlanecounty.org/get-help/programs-for-children/";
            l.Catagory = "Financial";
            l.SubCatagory = "Teen, Young Adult, Food Insecurity";

            links.Add(l);

            return links;
        }


    }
}
