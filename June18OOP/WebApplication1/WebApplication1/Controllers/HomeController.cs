using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
     

        public IActionResult Index()
        {
            ViewBag.Name = "Shalvin P D";
            ViewBag.Profession = ".Net Developer and Trainer";
            return View();
        }

        public IActionResult Trainees()
        {
            List<string> trainees = new List<string>(){"Shalvin", "Abinu", "Hima"};
            ViewBag.Trainees = trainees;
            return View();
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
