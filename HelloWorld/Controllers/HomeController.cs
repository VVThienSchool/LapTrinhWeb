using HelloWorld.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HelloWorld.Controllers
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
            ViewBag.name = "thien";
            ViewBag.now = DateTime.Now;
            ViewBag.test = "test ok";
            return View("myView");
        }

        public String Index2()
        {
            return "index 2";
        }
    }
}