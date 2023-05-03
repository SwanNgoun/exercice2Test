using Microsoft.AspNetCore.Mvc;

namespace Exercices2_controlleurs_tests.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
