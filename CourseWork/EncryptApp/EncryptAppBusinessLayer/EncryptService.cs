using EncryptAppBusinessLayer.Core.Abstractions;
using EncryptAppBusinessLayer.Core.EncryptAlgorithms;

namespace EncryptAppBusinessLayer
{
    public class EncryptService
    {
        private readonly IEncryptableAlgorithm _encryptAlgorithm;

        public EncryptService()
        {
            _encryptAlgorithm = new VigenereEncryptAlgorithm();
        }

        public string Encrypt(string key, string text)
        {
            return _encryptAlgorithm.Encrypt(key, text);
        }

        public string Decrypt(string key, string text)
        {
            return _encryptAlgorithm.Decrypt(key, text);
        }
    }
}