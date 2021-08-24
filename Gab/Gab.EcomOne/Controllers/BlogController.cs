using Microsoft.AspNetCore.Mvc;

namespace Gab.EcomOne.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult Details() => View();
    }
}
