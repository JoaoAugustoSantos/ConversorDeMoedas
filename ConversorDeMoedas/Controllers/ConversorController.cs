using ConversorDeMoedas.Models;
using ConversorDeMoedas.Services;
using Microsoft.AspNetCore.Mvc;

namespace ConversorDeMoedas.Controllers
{
    public class ConversorController : Controller
    {
        private readonly ConversorService _service;

        public ConversorController(ConversorService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = new ConversorModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Index(ConversorModel model)
        {
            if (ModelState.IsValid)
            {
                model.Result = await _service.Converter(model.FromCurrency, model.TargetCurrency, model.Value);
            }

            return View(model);
        }
    }
}
