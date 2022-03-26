using Microsoft.AspNetCore.Mvc;
using PatronDependencyInjection.Models;
using System.Diagnostics;

namespace PatronDependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private Persona _persona;

        public HomeController(Persona persona)
        {
            _persona = persona;
        }

        public IActionResult Index()
        {
            _persona.Nombre = "Joaquin";
            _persona.Apellido = "Gonzalez";
            _persona.Edad = 23;

            return View(_persona);
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