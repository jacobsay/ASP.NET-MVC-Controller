using Microsoft.AspNetCore.Mvc;
using ContentResult_JsonResult.Models;
using System.Text.Json;
using System;

namespace ContentResult_JsonResult.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("<h1>Hello User</h1><a href=\"/home/json\">Получить данные пользователя</a>", "text/html;charset=utf-8");
        }

        public IActionResult Json()
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                WriteIndented = true,
            };

            return Json(new User("Greed", 30), options);
        }
    }
}
