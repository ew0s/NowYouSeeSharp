using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace l9t15
{
    /*
     * Внутри класса Program создайте публичный статический метод CatXMLSerializer(), который
     * принимает экземпляр класса Cat и имя файла, после чего сериализует полученный экземпляр
     * в файл формата XML и соответствующим именем.
     * Файл должен располагаться в директории сборки проекта, при этом, если файл уже существует,
     * то он должен быть обновлён и всегда содержать лишь последний из сериализованных экземпляров.
     * При работе с файлом используйте абсолютный путь.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
        }

        public static void CatXMLSerializer(SpaceCat cat, string filePath)
        {
            using (FileStream fs = new FileStream(@"C:\Users\ew0s\Education\Course2\Lection9\l9t15\bin\Debug\" + filePath + ".xml", FileMode.Create))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(SpaceCat));
                xmlSerializer.Serialize(fs, cat);
            }
        }
    }
}
