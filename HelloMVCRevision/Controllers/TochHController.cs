using Microsoft.AspNetCore.Mvc;

namespace HelloMVCRevision.Controllers
{
    public class TochHController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
