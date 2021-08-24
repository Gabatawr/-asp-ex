using Microsoft.AspNetCore.Mvc;

namespace Gab.EcomOne.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index_1() => View();
        public IActionResult Index_2() => View();
        public IActionResult Index_3() => View();
    }
}
