using Microsoft.AspNetCore.Mvc;

namespace diveDeep.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FAQ()
        {
            return View();
        }
    }
}
