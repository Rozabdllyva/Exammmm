using Microsoft.AspNetCore.Mvc;

namespace Maxim.Areas.Admin.Controllers
{
    public class ContentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
