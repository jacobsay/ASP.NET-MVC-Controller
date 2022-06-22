using Microsoft.AspNetCore.Mvc;
using DependencyInjection.Services;
using System;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        ITimeService timeService;

        public HomeController(ITimeService timeService)
        {
            this.timeService = timeService;
        }

        public IActionResult Index()
        {
            return Content(timeService.Time);
        }

        public IActionResult FuncArg([FromServices] ITimeService? time)
        {
            if (time is null)
            {
                throw new ArgumentNullException(nameof(time));
            }

            return Content(time.Time);
        }

        [ActionName("Request")]
        public IActionResult Req()
        {
            ITimeService? time = HttpContext.RequestServices.GetService<ITimeService>();
            return Content(time?.Time ?? "Undefined");
        }
    }
}
