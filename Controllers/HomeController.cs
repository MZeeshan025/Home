using Microsoft.AspNetCore.Mvc;

namespace Zeeshan_Proj.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult Form()
        {
            return View();
        }
        public IActionResult Calculator()
        {
            return View();
        }
    }
}
