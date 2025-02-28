using CalculoApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalculoApp.Controllers
{
    public class CalculoController : Controller
    {
        public IActionResult Index()
        {
            return View(new CalculoModel());
        }

        [HttpPost]
        public IActionResult Calcular(CalculoModel model)
        {
            if (ModelState.IsValid)
            {
                Random random = new Random();
                model.NumeroAleatorio = random.Next(1, 100);

                
                model.Caida = model.Dato.Value * 0.1;
            }
            return View("Index", model);
        }
    }
}
