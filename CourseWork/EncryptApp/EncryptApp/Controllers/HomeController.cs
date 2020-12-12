using Microsoft.AspNetCore.Mvc;

namespace EncryptApp.Controllers
{
    public class HomeController : Controller
    { 
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public RedirectResult TextCipher()
        {
            return Redirect("/../CypherText/index");
        }

        public RedirectResult FileCipher()
        {
            return Redirect("/../CypherFile/index");
        }
    }
}