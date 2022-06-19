using Microsoft.AspNetCore.Mvc;
using System;
using Forms.Models;

namespace Forms.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public async Task Index()
        {
            Response.ContentType = "text/html;charset=utf-8";
            string html = @"<form method='post'>
                           <div>
                               Введите имя:
                                <input name='name'/>
                           </div>
                         <div>
                             Введите возраст:
                              <input type='number' name='age'/>
                         </div>
                         <div>
                               Языки: <br/>
                                      <input name='languages'/><br/>
                                       <input name='languages'/><br/>
                                        <input name='languages'/><br/>
                         </div>
                         <div>
                                  Номера телефонов: <br/>
                                  Домашний: <input type='number' name='phones[Home]'/><br/>
                                  Рабочий: <input type='number' name='phones[Work]'/><br/>
                                  Мобильный: <input type='number' name='phones[Mobil]'/><br/>
                         </div>
                         <input type='submit' value='Отправить'/>
                      </form>";

            await Response.WriteAsync(html);
        }

        [HttpPost]
        public string Index(Person person)
        {
            string languages = "Languages:\n";
            string phones = "Phones:\n";

            foreach (var lang in person.Languages)
            {
                languages += $"\t{lang}\n";
            }

            foreach (var phone in person.Phones)
            {
                phones += $"\t{phone.Key}: {phone.Value}\n";
            }

            return $"Name: {person.Name}\nAge: {person.Age}\n{languages}\n{phones}";
        }
    }
}
