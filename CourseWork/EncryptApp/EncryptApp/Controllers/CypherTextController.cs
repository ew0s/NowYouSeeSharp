using EncryptApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace EncryptApp.Controllers
{
    public class CypherTextController : Controller
    {
        public IActionResult Index()
        {
            return View(new EncryptedTextModel("hi"));
        }
        
        [HttpPost]
        public IActionResult CypheredText(string text, string cypherType)
        {
            return View(new EncryptedTextModel(text));
        }

        public IActionResult GoBack()
        {
            return RedirectToAction("Index");
        }
    }
}