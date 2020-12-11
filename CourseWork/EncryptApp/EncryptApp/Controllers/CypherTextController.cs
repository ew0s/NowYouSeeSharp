using System;
using Microsoft.AspNetCore.Mvc;

namespace EncryptApp.Controllers
{
    public class CypherTextController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        
        public IActionResult CypheredText(string text, string cypherType)
        {
            return PartialView(text);
        }
    }
}