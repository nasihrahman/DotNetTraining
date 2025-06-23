using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCHello.Models;

namespace MVCHello.Controllers
{
    public class HomeController : Controller
    {
     

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Training()
        {
            return View();
        }

        public IActionResult Adith()
        {
            return View();
        }
        public IActionResult Serin()
        {
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
