using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebVirus.DBModels;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using WebVirus.DBModels;

// using UserData.Data;
using WebVirus.Models;

namespace WebVirus.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly StorageContext _db;

    public HomeController(ILogger<HomeController> logger, StorageContext db)
    {
        _logger = logger;
        _db = db;
    }

    public IActionResult Index()
    {

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    // public IActionResult ForgotPWD()
    // {
    //     return View("ForgotPWD"); 
    // }
    public IActionResult CreateAcount()
    {
        return View("CreateAcount");
    }

    [BindProperty]
    public User user { get; set; }

    public IActionResult LoginValidation()
    {
        int x = 1;

        //dentro de los ifs, va a ir una query para checar si existe ese usuario
        //si da un 1, entonces significa que encontro uno parecido y por ende, es el chido

        if (x == 1) // Alumno
        {
            return View("~/Views/IndexForUser/AlmacenistIndex.cshtml"); //la vista, llamada index, y el layout que se va a utilizar
        }
        else if (x == 2) //Profesor
        {
            return View("~/Views/IndexForUser/Almacenist/AlmacenistIndex.cshtm");
        }
        else if (x == 3) //almacenista
        {
            return View("Index");
        }
        else if (x == 4) //Coordinador
        {
            return View("Index");
        }
        else //no hace nd, recarga la pagina y le vale mae
        {
            return RedirectToAction("Index");
        }
    }

    // [BindProperty]
    // public User user2 { get; set; }

    public IActionResult ForgotPWD()
    {
        //mejor obtenemos el puro valor, hay que quitar el string username
        //si el nombre es igual, entonces lo va a encontrar
        if (user is not null)
        {
            //pq xuxa dice no table called users
            var ExistUser = _db.Users.FirstOrDefault(u => u.User1 == user.User1);
            if (ExistUser != null)
            {
                return View("ForgotPWD");
                // return RedirectToAction("ResetPassword", new {UserId});
            }
            return View("ForgotPWD");
        }else
        {
            return View("ForgotPWD");
        }
    }

    //Descomentar luego
    // public IActionResult ResetPassword (int userId)
    // public IActionResult ResetPassword

    //esto supongo que es para manejar lo errores y muestre la view en donde te dice la linea de esta wea en la que falla
    //investigar para mejor info
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
