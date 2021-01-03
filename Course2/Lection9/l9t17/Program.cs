using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace l9t17
{
    /*
     * При запуске программы методу GetFromStream() будет передан поток, содержащий сериализованное
     * представление экземпляра класса SimpleCat, однако способ сериализации уточнён не будет, но
     * он точно один из уже изученных на курсе.
     * Реализуйте метод GetFromStream() так, чтобы вне зависимости от способа сериализации
     * мы всегда получали корректный объект соответствующего класса.
     * Сигнатуру метода GetFromStream() изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            using (FileStream fs = new FileStream(Directory.GetCurrentDirectory() + "\\xmlCat.xml", FileMode.Create))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(SimpleCat));
                xmlSerializer.Serialize(fs, new SimpleCat() {Age = 12});
                GetFromObject(fs);
            }
        }

        public static SimpleCat GetFromObject(Stream s)
        {
            var bytes = new List<byte>();

            using (s)
            {
                int i;
                do
                {
                    i = s.ReadByte();
                    if (i != -1) bytes.Add((byte)i);
                } 
                while (i != -1);
            }

            using (MemoryStream ms = new MemoryStream(bytes.ToArray()))
            {
                BinaryFormatter bf = new BinaryFormatter();
                return (SimpleCat)bf.Deserialize(ms);
            }
        }
    }
}
