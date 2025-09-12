using Microsoft.AspNetCore.Mvc;
using diveDeep.Services;

namespace diveDeep.Controllers
{
    public class ListController : Controller
    {
        public IActionResult Index()
        {
            var ids = ProductListService.GetAll();
            return View(ids);
        }

        [HttpPost]
        public IActionResult Add(int id)
        {
            ProductListService.Add(id);
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
