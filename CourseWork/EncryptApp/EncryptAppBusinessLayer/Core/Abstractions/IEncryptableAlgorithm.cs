namespace EncryptAppBusinessLayer.Core.Abstractions
{
    internal interface IEncryptableAlgorithm
    {
        string Encrypt(string key, string str);
        string Decrypt(string key, string str);
    }
}
