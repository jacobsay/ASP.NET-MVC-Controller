using Microsoft.AspNetCore.Mvc;

namespace RedefiningControllers.Controllers
{
    public class HomeController : LogBaseController
    {
        public IActionResult Index()
        {
            return Content("Hello GreeD!");
        }
    }
}
