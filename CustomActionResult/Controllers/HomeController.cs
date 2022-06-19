using Microsoft.AspNetCore.Mvc;
using CustomActionResult;
using System;

namespace CustomActionResult.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return new HtmlResult("<h2>Hello GreeD!</h2>");
        }

        public IActionResult File()
        {
            string path = Path.GetFullPath("wwwroot\\Index.html");
            return new PhysicalFileResult(path, "text/html;charset=utf-8");
        }
    }
}
