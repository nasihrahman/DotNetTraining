using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HelloMVCVSC.Models;

namespace HelloMVCVSC.Controllers;

public class HomeController : Controller
{
   
   pub

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult About()
    {
    return View();
    }

    public IActionResult Manav()
    {
        return View();
    }

public IActionResult Akhil()
    {
        return View();
    }
    public IActionResult IT()
    {


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
