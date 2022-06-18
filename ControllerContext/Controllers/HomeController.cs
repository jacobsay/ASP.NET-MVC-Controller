using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace ControllerContext.Controllers
{
    public class HomeController : Controller
    {
        public async Task Index()
        {
            Response.ContentType = "text/html; charset=utf-8";
            StringBuilder sb = new StringBuilder("<h2>Request headers</h2><table>");

            foreach (var header in Request.Headers)
            {
                sb.Append($"<tr><td>{header.Key}</td><td>{header.Value}</td></tr>");
            }

            sb.Append("</table>");
            await Response.WriteAsync(sb.ToString());
        }
    }
}
