using Microsoft.AspNetCore.Mvc;
using MvCSelectionInsertion.Models;
using System.Diagnostics;

namespace MvCSelectionInsertion.Controllers
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
                Location = Request.Form["location"],
            };
            tocHTraineesContext.Trainees.Add(trainee);
            tocHTraineesContext.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
