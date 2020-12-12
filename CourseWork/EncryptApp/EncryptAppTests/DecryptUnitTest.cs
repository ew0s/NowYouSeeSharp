using System.IO;
using EncryptAppBusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncryptAppTests
{
    [TestClass]
    public class DecryptUnitTest
    {
        [TestMethod]
        public void TestDecryptText()
        {
            var encryptService = new EncryptService();
            var encryptedText = File.ReadAllText(@"../../../TestFiles/Encrypted.txt");
            var decryptedText = encryptService.Decrypt("скорпион", encryptedText);
            Assert.AreEqual(decryptedText, File.ReadAllText(@"../../../TestFiles/Decrypted.txt"));
        }
    }
}