using Microsoft.AspNetCore.Mvc;
using Redirect.Models;
using System;

namespace Redirect.Controllers
{
    public class RedirectController : Controller
    {
        public IActionResult Redirect()
        {
            return Redirect("~/Home/Index");
        }

        public IActionResult RedirectPer()
        {
            return RedirectPermanent("~/Home/About");
        }

        public IActionResult RedirectToAct()
        {
            return RedirectToAction("Info", "Home", new User("Greed", 30));
        }

        public IActionResult RedirectToRoute()
        {
            return RedirectToRoute("default", new { controller = "Home", action = "Info", name = "Greed", age = 30 });
        }
    }
}
