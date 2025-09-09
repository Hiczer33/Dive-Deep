using Microsoft.AspNetCore.Mvc;

namespace diveDeep.Controllers
{
    public class FaqController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}