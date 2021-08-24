using Microsoft.AspNetCore.Mvc;

namespace Gab.EcomOne.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult Details() => View();
    }
}
