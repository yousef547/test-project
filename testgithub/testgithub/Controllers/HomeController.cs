using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using testgithub.Models;

namespace testgithub.Controllers
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
            return View();
        }
        public IActionResult testOne()
        {
            var Name = "taghreed Ashraf";
            return View(Name);
        }

        public IActionResult testTwo()
        {

            var newtes = "hello from egypt";
            return View(newtes);
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
}