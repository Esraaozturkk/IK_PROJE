using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using IK_PROJE.MVC.Models;
using IK_PROJE.MVC.Models.VMs;

namespace IK_PROJE.MVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
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

    public IActionResult CreateCV()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreateCV (CreateCVVM model)
    {
        if (ModelState.IsValid)
        {
            // Model verilerini kaydetme iþlemi
            return RedirectToAction("Success");
        }

        return View(model);
    }

}
