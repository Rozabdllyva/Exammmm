﻿using Microsoft.AspNetCore.Mvc;

namespace Maxim.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
