using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace l9t12
{
    /*
     * Внутри класса Program создайте публичный статический метод CatXMLDeserializer(), который принимает
     * путь к файлу, в котором находится XML представление экземпляра класса SpaceCat, и возвращает соответствующий 
     * экземпляр класса.
     * При десериализации необходимо использовать XML представление и FileStream.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
        }

        public static SpaceCat CatXMLDeserializer(string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(SpaceCat));
                return (SpaceCat) xmlSerializer.Deserialize(fs);
            }
        }
    }
}
