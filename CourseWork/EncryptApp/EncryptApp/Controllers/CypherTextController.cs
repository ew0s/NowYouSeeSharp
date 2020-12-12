using System;
using System.IO;
using EncryptApp.Models;
using EncryptAppBusinessLayer;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace EncryptApp.Controllers
{
    public class CypherTextController : Controller
    {
        IWebHostEnvironment _appEnvironment;
 
        public CypherTextController(IWebHostEnvironment appEnvironment)
        {
            _appEnvironment = appEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult CypheredText(string key, string text, string cypherType)
        {
            if (string.IsNullOrEmpty(key) || string.IsNullOrEmpty(text))
            {
                return RedirectToAction("Index");
            }

            var result = cypherType == "Encrypt" ? new EncryptService().Encrypt(key, text) : new EncryptService().Decrypt(key, text);
            using var fs = new FileStream(_appEnvironment.WebRootPath + "/Files/TmpText.txt", FileMode.Create);
            using var sw = new StreamWriter(fs);
            sw.WriteAsync(result);

            return View(new EncryptedTextModel(result));
        }

        public IActionResult GoBack()
        {
            return RedirectToAction("Index");
        }

        public IActionResult DownloadFile(string filePath)
        {
            try
            {
                using var fs = new FileStream(filePath, FileMode.Create);
                using var sw = new StreamWriter(fs);
                sw.WriteAsync(System.IO.File.ReadAllText(_appEnvironment.WebRootPath + "/Files/TmpText.txt"));
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }
    }
}