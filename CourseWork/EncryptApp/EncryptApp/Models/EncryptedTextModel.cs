using System.IO;

namespace EncryptApp.Models
{
    public class EncryptedTextModel
    {
        public static Stream FileStream { get; set; }
        public readonly string Text;

        public EncryptedTextModel(string text)
        {
            Text = text;
        }
    }
}