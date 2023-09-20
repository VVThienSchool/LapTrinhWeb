using HelloWorld.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    [Route("/")]
    public class MyController : Controller
    {
        [HttpGet]
        [Route("/my/regist")]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [Route("/my/regist")]
        public IActionResult Register(Student student)
        {
            return View("Thanks", student);
        }
    }
}
