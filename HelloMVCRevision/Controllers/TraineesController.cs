using HelloMVCRevision.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloMVCRevision.Controllers
{
    public class TraineesController : Controller
    {
        List<string> trainees = new List<string>() 
        { "Swetha", "Aiswarya", "Aparna", "Serin"};

        List<Trainee> traineesInfo = new List<Trainee>() {
         new Trainee{Name = "Anjana", Branch = "IT", Location = "Malapuram"}
        };

        Trainee trainee = new Trainee()
        {
            Name = "Alan",
            Location = "Kaloor",
            Branch = "IT"
        };
        public IActionResult Index()
        {
            ViewBag.Trainees = trainees;
            return View();
        }

        public IActionResult TraineeInfo()
        {
         
            traineesInfo.Add(trainee);

            return View(traineesInfo);
        }

        public IActionResult Trainee2()
        {
            return View(traineesInfo);
        }
    }
}
