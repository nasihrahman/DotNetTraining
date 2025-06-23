using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TochTraineeManagementSelect.Models;

namespace TochTraineeManagementSelect.Controllers
{
    public class HomeController : Controller
    {
        TocHTraineesContext tocHTraineesContext = new TocHTraineesContext();

        public IActionResult Index()
        {
            return View(tocHTraineesContext.Trainees.ToList());
        }

      public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string str)
        {
            Trainee trainee = new Trainee()
            {
                Name = Request.Form["name"],
                Location = Request.Form["location"]
            };
            tocHTraineesContext.Trainees.Add(trainee);
            tocHTraineesContext.SaveChanges();
            return RedirectToAction("Index");
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
