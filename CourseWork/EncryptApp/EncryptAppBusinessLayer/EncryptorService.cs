using System;
using System.Collections.Generic;
using System.IO;
using EncryptAppBusinessLayer.Core.Abstractions;
using EncryptAppBusinessLayer.Core.Adapters;
using EncryptAppBusinessLayer.Core.EncryptAlgorithms;
using EncryptAppBusinessLayer.Core.Exceptions;

namespace EncryptAppBusinessLayer
{
    public class EncryptorService
    {
        private readonly FileInfo _fileInfo;
        private readonly IEncryptableAlgorithm _encryptAlgorithm;
        private EncryptAdapter _encryptAdapter;

        public EncryptorService(string filePath)
        {
            if (!File.Exists(filePath)) throw new FileNotFoundException();
            _fileInfo = new FileInfo(filePath);

            if (!TrySelectAdapter(out var encryptAdapter))
                throw new InvalidExtensionFormatException($"{_fileInfo.Extension}");
            _encryptAdapter = encryptAdapter;
            _encryptAlgorithm = new VigenereEncryptAlgorithm();
        }

        public void Encrypt(string pathToFile, string key, IEnumerable<string> text)
        {
            using (var fs = new FileStream(pathToFile, FileMode.Create))
            {
                using (var sw = new StreamWriter(fs))
                {
                    foreach (var str in text)
                    {
                        sw.Write(_encryptAlgorithm.Encrypt(key, str));
                    }
                }
            }
        }

        public void Decrypt(string pathToFile, string key, IEnumerable<string> text)
        {
            using (var fs = new FileStream(pathToFile, FileMode.Create))
            {
                using (var sw = new StreamWriter(fs))
                {
                    foreach (var str in text)
                    {
                        sw.Write(_encryptAlgorithm.Decrypt(key, str));
                    }
                }
            }
        }

        private bool TrySelectAdapter(out EncryptAdapter encryptAdapter)
        {
            switch (_fileInfo.Extension)
            {
                case ".txt":
                    encryptAdapter = new TxtToStringListAdapter(_fileInfo);
                    return true;
                case ".doc":
                case ".docx":
                    encryptAdapter = new DocxToStringListAdapter(_fileInfo);
                    return true;
                default:
                    encryptAdapter = null;
                    return false;
            }
        }
    }
}