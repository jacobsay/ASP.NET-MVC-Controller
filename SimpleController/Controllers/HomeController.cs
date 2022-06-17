using Microsoft.AspNetCore.Mvc;
using System;

namespace SimpleController.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public string Index()
        {
            return "Hello GreedNeSS!";
        }

        [ActionName("Info")]
        public string About()
        {
            return "Info Page!";
        }
    }
}
