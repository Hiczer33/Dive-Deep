using Microsoft.AspNetCore.Mvc;

namespace diveDeep.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}