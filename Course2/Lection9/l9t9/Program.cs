using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;

namespace l9t9
{
    /*
     * Внутри класса Program создайте публичный статический метод CatSOAPSerializer(), который
     * принимает экземпляр класса Cat и имя файла, после чего помещает сериализованное представление
     * полученного экземпляра в файл формата SOAP и соответствующим именем. Метод ничего не должен возвращать.
     * Файл должен располагаться в папке сборки проекта, при этом если файл уже существует,
     * то он должен быть обновлён и всегда содержать лишь последний из сериализованных экземпляров.
     * При работе с файлом, используйте абсолютный путь.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            CatSOAPSerializer(new Cat {Age = 12, Name = "BOBIasdfljas;ldfkjK"}, "soapCat");
        }

        public static void CatSOAPSerializer(Cat cat, string fileName)
        {
            using (FileStream fs = new FileStream(@"C:\Users\ew0s\Education\Course2\Lection9\l9t9\bin\Debug\" + fileName + ".soap", FileMode.Create))
            {
                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(fs, cat);
            }
        }
    }
}
