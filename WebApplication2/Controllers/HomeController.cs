using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.IO.Pipes;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
         
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Index(string str)
        {
            ViewBag.Hello = $"Hello {Request.Form["Name"]} at {Request.Form["Location"]}";
            return View();
        }
        public IActionResult Prooop()
        {
            return View();
        }
        public IActionResult Properties()
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
