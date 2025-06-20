using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TraineeManagementSelect.Models;

namespace TraineeManagementSelect.Controllers
{
    public class HomeController : Controller
    {
      TocHTraineesContext tocHTraineesContext = new TocHTraineesContext();

        public IActionResult Index()
        {
            return View(tocHTraineesContext.Trainees.ToList());
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
