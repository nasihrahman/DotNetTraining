using GenericListOfClassMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GenericListOfClassMVC.Controllers
{
    public class HomeController : Controller
    {
       List<TouristLocations> touristLocations = new List<TouristLocations>() { 
       new TouristLocations{Name = "Arikkal Waterfalls", District = "Ernakulam"},
       new TouristLocations{Name = "Aleppey Backwaters", District = "Aleppey"},
       new TouristLocations{Name = "Fort Kochi", District = "Ernakulam" }
           };


        public IActionResult Index()
        {
            ViewBag.Locations = touristLocations;
            return View();
        }

        public IActionResult MB()
        {
            return View(touristLocations);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
