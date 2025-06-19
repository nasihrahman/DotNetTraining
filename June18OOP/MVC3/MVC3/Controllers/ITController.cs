using Microsoft.AspNetCore.Mvc;

namespace MVC3.Controllers
{
    public class ITController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Neha()
        {
            return View();
        }

        public IActionResult Liya()
        {
            return View();
        }
    }
}
