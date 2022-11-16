using Group2Web2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Group2Web2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            List<Studenti> lista = new List<Studenti>();
            Studenti st1 = new Studenti("Kastriot", "Gjoka");
            Studenti st2 = new Studenti("Florent", "Hajdari");
            lista.Add(st1);
            lista.Add(st2);

            return View(lista);
        }

        public IActionResult MesoHtml()
        {
            // return Content("<h1>Kolegji AAB</h1>");
            return View();
        }
    }
}
