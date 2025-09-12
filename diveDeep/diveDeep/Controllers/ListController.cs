using Microsoft.AspNetCore.Mvc;
using diveDeep.Services;

namespace diveDeep.Controllers
{
    public class ListController : Controller
    {
        // Viser hele listen i Views/List/Index.cshtml
        public IActionResult Index()
        {
            var items = ProductListService.GetAll(); // returnerer List<ListEntry>
            return View(items);
        }

        [HttpPost]
        public IActionResult Add(string category, int id)
        {
            ProductListService.Add(category, id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Clear()
        {
            ProductListService.Clear();
            return RedirectToAction("Index");
        }
    }
}

