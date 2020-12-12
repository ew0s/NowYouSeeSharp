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
        private readonly IWebHostEnvironment _appEnvironment;
        private static string _encryptedText;
 
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
            _encryptedText = result;

            return View(new EncryptedTextModel(result));
        }

        public IActionResult GoBack()
        {
            return RedirectToAction("Index");
        }

        public IActionResult DownloadFile(string directoryPath, string fileName)
        {
            if (!Directory.Exists(directoryPath)) return RedirectToAction("Index");
            var path = directoryPath + "/" + fileName + ".txt";
            try
            {
                using var fs = new FileStream(path, FileMode.Create);
                using var sw = new StreamWriter(fs);
                sw.WriteAsync(_encryptedText);
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }
    }
}