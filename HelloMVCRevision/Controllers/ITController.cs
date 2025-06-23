using Microsoft.AspNetCore.Mvc;

namespace HelloMVCRevision.Controllers
{
    public class ITController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
