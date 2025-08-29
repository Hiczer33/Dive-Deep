using Microsoft.AspNetCore.Mvc;

namespace diveDeep.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
