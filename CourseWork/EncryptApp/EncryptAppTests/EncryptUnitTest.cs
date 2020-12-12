using System.IO;
using EncryptAppBusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncryptAppTests
{
    [TestClass]
    public class EncryptUnitTest
    {
        [TestMethod]
        public void TestEncryptText()
        {
            var encryptService = new EncryptService();
            var decryptedText = File.ReadAllText(@"../../../TestFiles/Decrypted.txt");
            var encryptedText = encryptService.Encrypt("скорпион", decryptedText);
            Assert.AreEqual(encryptedText, File.ReadAllText(@"../../../TestFiles/Encrypted.txt"));
        }
    }
}