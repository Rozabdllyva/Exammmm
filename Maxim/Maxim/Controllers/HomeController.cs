using Microsoft.AspNetCore.Mvc;

namespace Maxim.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
