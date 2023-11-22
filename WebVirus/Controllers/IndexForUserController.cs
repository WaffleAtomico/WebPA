using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebVirus.DBModels;
using WebVirus.Models;

namespace WebVirus.Controllers
{
    [Route("[controller]")]
    public class IndexForUserController : Controller
    {
        private readonly ILogger<IndexForUserController> _logger;
        private readonly StorageContext _db;

        public IndexForUserController(ILogger<IndexForUserController> logger, StorageContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }
        //cuando mandamos a llamar a studentIndex, por defecto, haremos que envie un objeto de tipo user
        //esto para que podamos hacer la comparacion y obtener todas
        //las ordenes que tengan su id
        [BindProperty]
        public User user { get; set; }
        public IActionResult StudentIndex()
        {
            DbSet<Student> student = _db.Students;
            DbSet<Order> orders = _db.Orders;
            // var ExactStudent = student.Where(s => s.Records == user.UserId);
            ViewBag.Order = orders.Where(o => o.FkStudent == user.UserId);
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}