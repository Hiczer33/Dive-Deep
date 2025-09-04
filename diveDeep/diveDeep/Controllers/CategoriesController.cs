using diveDeep.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace diveDeep.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Finner()
        {
            var model = FinsRepository.GetAll();
            return View();
        }

        public IActionResult MaskeSnorkel()
        {
            var model = MaskSnorkelRepository.GetAll();
            return View();
        }

        public IActionResult Regulatorsæt()
        {
            var model = RegulatorsetRepository.GetAll();
            return View();
        }

        public IActionResult Tank()
        {
            var model = TankRepository.GetAll();
            return View();
        }

        public IActionResult Dykkerdragt()
        {
            var model = DykkerdragtRpeository.GetAll();
            return View(model);
        }

        public IActionResult BCD()
        {
            var model = BCDRepository.GetAll();
            return View(model);
        }

        public IActionResult Pakke()
        {

            return View();
        }
    }
}
