using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebVirus.Controllers
{
    [Route("[controller]")]
    public class SharedController : Controller
    {
        private readonly ILogger<SharedController> _logger;

        public SharedController(ILogger<SharedController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        // ok, aqui no tengo npi de como hacerlo
        //se supone quiero poner una imagen en el label que tenga esta madre, pero cuando un usuario
        //ya se ha dado de alta
        //aqui el problema es que tenemos que saber, 1, el tipo de usuario, para mostrar unos
        //u otros, se supone, en este controlador se va a tener que hacer solamente una cosa
        //mandar a la vista que le corresponde al usuario para que pueda cambiar su info (op 1)
        //supongo que cada uno de estos debe de recibir
        //la otra es que depende de la info que tenga el usuario que le enviemos
        //lo mande a una interfaz, ya sin hacer un metodo para cada uno (op 2)

        //op 2
        public IActionResult StudentChangeInfo()
        {
            //aqui adentro leemos el usuario y la contraseña con los que ya inicio
            //y con esos datos determinamos que tipo de usuario es
            //
            int x = 0;
            
            //dentro de los ifs, va a ir una query para checar si existe ese usuario
            //si da un 1, entonces significa que encontro uno parecido y por ende, es el chido
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
                return View("Index");
            }
            else if (x == 4) //Coordinador
            {
                return View("Index");
            }
            else //es imposible que un usuario que ya entro, no sea perteneciente a un grupo de estos
            {
                return NotFound(); 
            }
        }

        //op 1
        /*
        public IActionResult StudentChangeInfo()
        {
            return View();
        }
        public IActionResult ProfesorChangeInfo()
        {
            return View();
        }
        public IActionResult AlmacenistChangeInfo()
        {
            return View();
        }
        public IActionResult CoordinatorChangeInfo()
        {
            return View();
        }
        */

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}