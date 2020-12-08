using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EncryptApp.Models;
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
        [HttpPost]
        public async Task<IActionResult> AddFile(IFormFile uploadedFile)
        {
            if (uploadedFile == null) return RedirectToAction("Index");
            var path = "/Files/" + uploadedFile.FileName;
            await using var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create);
            await uploadedFile.CopyToAsync(fileStream);

            return RedirectToAction("Index");
        }
    }
}