using diveDeep.Models;
using Microsoft.AspNetCore.Mvc;

namespace diveDeep.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edit(int? id)
        {
            var category = new Category { CategoryId = id.HasValue ? id.Value : 0 };
            return View(category);
        }

        public IActionResult Finner()
        {
            return View();
        }

        public IActionResult MaskeSnorkel()
        {
            return View();
        }

        public IActionResult Regulatorsæt()
        {
            return View();
        }

        public IActionResult Tank()
        {
            return View();
        }

        public IActionResult Dykkerdragt()
        {
            return View();
        }

        public IActionResult BCD()
        {
            return View();
        }

        public IActionResult Pakke()
        {
            return View();
        }
    }
}
