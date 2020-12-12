using System;
using System.IO;
using System.Threading.Tasks;
using EncryptApp.Models;
using EncryptAppBusinessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EncryptApp.Controllers
{
    public class CypherFileController : Controller
    {
        private static string _encryptedText;
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CypheredText(IFormFile uploadedFile, string cypherType, string key)
        {
            if (uploadedFile == null) return RedirectToAction("Index");
            if (string.IsNullOrEmpty(key))
            {
                return RedirectToAction("Index");
            }

            try
            {
                await using var fs = uploadedFile.OpenReadStream();
                using var sr = new StreamReader(fs);
                var textFromFile = await sr.ReadToEndAsync();
                _encryptedText = cypherType == "Encrypt" ? new EncryptService().Encrypt(key, textFromFile) : new EncryptService().Decrypt(key, textFromFile);
                return View(new EncryptedTextModel(_encryptedText));
            }
            catch (Exception)
            {
                return RedirectToAction("Index");
            }
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