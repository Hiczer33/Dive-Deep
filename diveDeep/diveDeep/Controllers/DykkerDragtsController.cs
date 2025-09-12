using diveDeep.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace diveDeep.Controllers
{
    public class DykkerDragtsController : Controller
    {
        public IActionResult Index(int? id)
        {
            var _dykkerDragtView = DykkerdragtRpeository.GetById(id.HasValue ? id.Value : 0);
            return View(_dykkerDragtView);
        }
    }
}
