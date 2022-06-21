using Microsoft.AspNetCore.Mvc;
using System;

namespace StatusCode.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Ok(new {message = "Hello Greed"});
        }

        public IActionResult Auth(int? age)
        {
            if (age is null)
            {
                return BadRequest(new { message = "Неизвeстен возраст" });
            }

            if (age < 18)
            {
                return Unauthorized(new { message = "Доступ запрешён!" });
            }
            else
            {
                return Ok(new { message = "Доступ развешен!" });
            }
        }

        [ActionName("NotFound")]
        public IActionResult NotF()
        {
            return NotFound("Неизвестный ресурс");
        }
    }
}
