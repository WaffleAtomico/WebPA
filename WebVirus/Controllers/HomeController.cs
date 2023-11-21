using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UserData.Data;
using WebVirus.Models;

namespace WebVirus.Controllers;

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

    public IActionResult ForgotPWD()
    {
        return View("ForgotPWD");
    }
    public IActionResult CreateAcount()
    {
        return View("CreateAcount");
    }
    [BindProperty]
    public User user {get; set;}
    public IActionResult LoginValidation()
    {
        return View("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
