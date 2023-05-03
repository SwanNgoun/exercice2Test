using Microsoft.AspNetCore.Mvc;

namespace Exercice2.Controllers
{
    public class HomeController : Controller
    {
        //no1, on veut juste retourner sous forme en string
        public string Index()
        {
            return "<h2>Bienvenu dans mon site web</h2>";
        }
       
        //no2, on veut le retour soir ContentResult 
        public ContentResult Index2()
        {

            return Content("<h2>Bienvenu dans mon site web</h2>", "text/html");

        }

        //no3, il ne fonctionne pas, car le view n'a pas été crée
        public IActionResult Index3()
        {
            return View();
        }

        //no4, créer une méthode d'action qui retourne un fichier pdf
        

    }
}
