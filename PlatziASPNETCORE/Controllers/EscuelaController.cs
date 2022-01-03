using Microsoft.AspNetCore.Mvc;
using PlatziASPNETCORE.Models;

namespace PlatziASPNETCORE.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            Escuela escuela = new Escuela();
            escuela.Id = Guid.NewGuid().ToString();
            escuela.Name = "ITPN";
            escuela.FoundationYear = 1972;

            ViewBag.CosaDinamica = "Michael Myers";

            return View(escuela);
        }
    }
}
