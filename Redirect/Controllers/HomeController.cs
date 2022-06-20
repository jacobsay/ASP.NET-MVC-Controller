using Microsoft.AspNetCore.Mvc;
using Redirect.Models;
using System;

namespace Redirect.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Content");
        }

        public IActionResult About()
        {
            return Content("About");
        }

        public IActionResult Info(User user)
        {
            return Json(user);
        }
    }
}
