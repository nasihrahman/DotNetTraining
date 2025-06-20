using HelloMVCRevision.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HelloMVCRevision.Controllers
{
    public class HomeController : Controller
    {
        Trainee akhil = new Trainee()
        {
            Name = "Akhil K S",
            Location = "Mulanthurithi",
            Branch = "IT"
        };

        public IActionResult MB()
        {
            return View(akhil);
        }

        public IActionResult Index()
        {
            ViewBag.Name = "Saurav";
            ViewBag.Location = "Piravom";
            ViewBag.Branch = "IT";
            return View();
        }

        public IActionResult Akhil()
        {
          
            ViewBag.Akhil = akhil;
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
