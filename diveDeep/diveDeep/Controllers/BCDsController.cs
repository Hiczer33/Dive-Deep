using diveDeep.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace diveDeep.Controllers
{
    public class BCDsController : Controller
    {
        public IActionResult Index(int? id)
        {
            ViewBag.Action = "Edit";
            var _bcdView = BCDRepository.GetById(id.HasValue ? id.Value : 0);
            return View(_bcdView);
        }
        IActionResult Add()
        {

        }
    }
}
