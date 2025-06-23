using Microsoft.AspNetCore.Mvc;

namespace MVC3.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            List<string> menu = new List<string>() { "Tea", "Coffee", "Pazham Pori" };
            ViewBag.Menu = menu;
            return View();
        }
    }
}
