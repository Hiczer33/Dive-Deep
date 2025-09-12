using Microsoft.AspNetCore.Mvc;
using diveDeep.Models;

namespace diveDeep.Controllers
{
    public class BookingController : Controller
    {
 
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ConfirmBooking(Booking booking)
        {
            if (!ModelState.IsValid) return View("Index", booking);

            return RedirectToAction("Success");
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}
