using Microsoft.AspNetCore.Mvc;

namespace HelloMVCRevision.Controllers
{
    public class TraineesController : Controller
    {
        List<string> trainees = new List<string>() 
        { "Swetha", "Aiswarya", "Aparna", "Serin"};

        public IActionResult Index()
        {
            ViewBag.Trainees = trainees;
            return View();
        }
    }
}
