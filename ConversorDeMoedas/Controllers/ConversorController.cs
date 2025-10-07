using Microsoft.AspNetCore.Mvc;

namespace ConversorDeMoedas.Controllers
{
    public class ConversorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
