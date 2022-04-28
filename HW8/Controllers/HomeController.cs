using HW8.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HW8.Controllers
{
    public class HomeController : Controller
    {
       
        private readonly ILogger<HomeController> _logger;
        
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var persons = PersonDb.GetAllPerson();
            return View(persons);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View ("Contact");
        }

        public IActionResult Remove(int id)
        {
            var result = PersonDb.Delete(id);
           return RedirectToAction ("Index");
        }

      public IActionResult layout()
        {
            return View("layout");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var persons = PersonDb.GetById(id);
            return View(persons);
        }
        [HttpPost]
        //public IActionResult Edit(Person model)
        //{
        //    PersonDb.UpdatePerson(model);
        //    return RedirectToAction("Index");
        //}


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}