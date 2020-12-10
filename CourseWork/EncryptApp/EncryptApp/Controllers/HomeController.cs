using System.IO;
using System.Threading.Tasks;
using EncryptAppBusinessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace EncryptApp.Controllers
{
    public class HomeController : Controller
    {
        IWebHostEnvironment _appEnvironment;
 
        public HomeController(IWebHostEnvironment appEnvironment)
        {
            _appEnvironment = appEnvironment;
        }
 
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        public string GetId(int id)
        {
            return id.ToString();
        }

        [HttpPost]
        public async Task<IActionResult> AddFile(IFormFile uploadedFile)
        {
            if (uploadedFile == null) return RedirectToAction("Index");
            var path = "/Files/" + uploadedFile.FileName;
            await using var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create);
            await uploadedFile.CopyToAsync(fileStream);
            

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Menu()
        {
            return RedirectToAction("Index");
        }
    }
}