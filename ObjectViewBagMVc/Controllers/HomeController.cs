using Microsoft.AspNetCore.Mvc;
using ObjectViewBagMVc.Models;
using System.Diagnostics;

namespace ObjectViewBagMVc.Controllers
{
    public class HomeController : Controller
    {
        //Object Initialization
        Contact haben = new Contact(){ Name = "Haben", Location = "Mulanthuruthi"};
        public IActionResult Index()
        {
            ViewBag.Contact = haben;
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
