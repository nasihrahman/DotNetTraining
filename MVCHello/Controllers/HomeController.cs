using Microsoft.AspNetCore.Mvc;
using MVCHello.Models;
using System.Diagnostics;

namespace MVCHello.Controllers
{
    public class HomeController : Controller
    {
     

        public IActionResult Index()
        {
            ViewBag.Name = "Shalvin";
            return View();
        }

        public IActionResult IT()
        {
            return View();
        }
        public IActionResult Manav()
        {
            return View();
        }
        public IActionResult Basil()
        {
            return View();
        }
        public IActionResult CS()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        
    }
}
