using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace l9t13
{
    /*
     * Внутри класса Program создайте публичный статический метод CatXMLDeserializer(), который принимает
     * путь до XML представления класса SpaceCat и возвращает соответствующий экземпляр класса.
     * При сериализации необходимо использовать XML представление и MemoryStream.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
        }

        public static SpaceCat CatXMLDeserializer(string filePath)
        {
            using (MemoryStream ms = new MemoryStream(File.ReadAllBytes(filePath)))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(SpaceCat));
                return (SpaceCat) xmlSerializer.Deserialize(ms);
            }
        }
    }
}
