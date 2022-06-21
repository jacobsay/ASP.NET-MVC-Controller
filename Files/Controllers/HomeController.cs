using Microsoft.AspNetCore.Mvc;
using System;

namespace Files.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return File("Index.html", "text/html;charsset=utf-8");
        }

        public IActionResult GetFile()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "wwwroot/File.txt");
            string type = "text/plain";
            string name = "Text1.txt";
            return PhysicalFile(path, type, name);
        }

        public IActionResult GetBytes()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "wwwroot/File2.txt");
            byte[] buffer = System.IO.File.ReadAllBytes(path);
            string type = "text/plain";
            string name = "Text2.txt";
            return File(buffer, type, name);
        }

        public IActionResult GetStream()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "wwwroot/File3.txt");
            FileStream fs = new FileStream(path, FileMode.Open);
            string type = "text/plain";
            string name = "Text3.txt";
            return File(fs, type, name);
        }
    }
}
