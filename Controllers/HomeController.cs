using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using suave.Models;

namespace suave.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        TempData["Nome"] = "Cleyton";
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
