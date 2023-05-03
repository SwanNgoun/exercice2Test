using Microsoft.AspNetCore.Mvc;

namespace Exercices2_controlleurs_tests.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult WelcomeDefault()
        {
            return Content("Bienvenue dans ma nouvelle application!");
        }

        public IActionResult WelcomeName(string nom, string prenom)
        {
            //return Content("Salut " + prenom + " " + nom + "! Bienvenue dans ma nouvelle application!");
            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(prenom))
            {
                return View("Erreur");
            }
            else
            {
                ViewData["nom"] = nom;
                ViewData["prenom"] = prenom;

                return View("Welcome");
            }
        }
    }
}
