using EncryptAppBusinessLayer.Core.Abstractions;

namespace EncryptAppBusinessLayer.Core.EncryptAlgorithms
{
    internal class VigenereEncryptAlgorithm : IEncryptableAlgorithm
    {
        private delegate int ShiftMethod(char keyChar, char strChar);

        private const string Alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

        public string Decrypt(string key, string str)
        {
            ShiftMethod shiftMethod = CalculateShiftForDecryption;
            return Cipher(key, str, shiftMethod);
        }
        
        public string Encrypt(string key, string str)
        {
            ShiftMethod shiftMethod = CalculateShiftForEncryption;
            return Cipher(key, str, shiftMethod);
        }

        private static string Cipher(string key, string str, ShiftMethod shiftMethod)
        {
            var encryptedText = "";
            var keyIndex = 0;

            foreach (var symbol in str)
            {
                if (!Alphabet.Contains(symbol.ToString()))
                {
                    encryptedText += symbol;
                    continue;
                }
                var shiftedIndex = shiftMethod(key[keyIndex], symbol);
                keyIndex++;
                
                if (keyIndex == key.Length) keyIndex = 0;
                if (char.IsUpper(symbol)) encryptedText += char.ToUpper(Alphabet[shiftedIndex]);
                else encryptedText += Alphabet[shiftedIndex];
            }

            return encryptedText;
        }

        private static int CalculateShiftForEncryption(char keyChar, char strChar)
        {
            return (Alphabet.IndexOf(keyChar) + Alphabet.IndexOf(strChar)) % 33;
        }
        
        private static int CalculateShiftForDecryption(char keyChar, char strChar)
        {
            return (Alphabet.IndexOf(strChar) - Alphabet.IndexOf(keyChar) + 33) % 33;
        }
    }
}