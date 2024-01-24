using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

using WebApplication2.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new TipCalculator();
            return View(model);
        }

        [HttpPost]
        public IActionResult Calculate(TipCalculator model)
        {
            if (ModelState.IsValid)
            {
                return View("Index", model);
            }
            return View("Index", model);
        }

        public IActionResult Clear()
        {
            var model = new TipCalculator();
            return View("Index", model);
        }
    }
}
