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
    public User user { get; set; }
    public IActionResult LoginValidation()
    {
        int x = 1;
        if (x == 1) // Alumno
        {
            return View("~/Views/IndexForUser/Almacenist/AlmacenistIndex.cshtml"); //la vista, llamada index, y el layout que se va a utilizar
        }
        else if (x == 2) //Profesor
        {
            return View("~/Views/IndexForUser/Almacenist/AlmacenistIndex.cshtm");
        }
        else if (x == 3) //almacenista
        {
            return View("Index", "_Layout");
        }
        else if (x == 4) //Coordinador
        {
            return View("Index", "_Layout");
        }
        else
        {
            return View("Index", "_Layout");
        }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
