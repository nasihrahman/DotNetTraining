using hellomvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace hellomvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Trainees()
        {
            List<string> Trainee = new List<string>
            {
                "Alan","adarsh"
            };

            ViewBag.trainee = Trainee;
        }
        public IActionResult Index()
        {
            ViewBag.Name = "Shalvin P D";
            ViewBag.Prof = ".net";
            return View();
        }
        public IActionResult Alann()
        {
            return Alann();
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
