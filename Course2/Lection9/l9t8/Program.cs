using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;

namespace l9t8
{
    /*
     * Внутри класса Program создайте публичный статический метод CatSOAPDeserializer(), который принимает
     * строковое SOAP представление класса SpaceCat и возвращает соответствующий экземпляр класса.
     * При сериализации необходимо использовать SOAP представление и MemoryStream.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
        }

        public static SpaceCat CatSOAPDeserializer(string soapCat)
        {
            var byteCat = Encoding.UTF8.GetBytes(soapCat);
            using (MemoryStream ms = new MemoryStream(byteCat))
            {
                SoapFormatter sf = new SoapFormatter();
                return (SpaceCat) sf.Deserialize(ms);
            }
        }
    }
}
