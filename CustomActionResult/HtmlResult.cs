using Microsoft.AspNetCore.Mvc;

namespace CustomActionResult
{
    public class HtmlResult : IActionResult
    {
        string htmlCode;

        public HtmlResult(string html)
        {
            htmlCode = html;
        }

        public async Task ExecuteResultAsync(ActionContext context)
        {
            string fullHtmlCode = @$"<!DOCTYPE html>
            <html>
                <head>
                    <title>Greed.com</title>
                    <meta charset=utf-8 />
                </head>
                <body>{htmlCode}</body>
            </html>";
            
            await context.HttpContext.Response.WriteAsync(fullHtmlCode);
        }
    }
}
