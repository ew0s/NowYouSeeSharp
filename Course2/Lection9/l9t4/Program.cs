using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace l9t4
{
    /*
     * Внутри класса Program создайте публичный статический метод DogBinarySerializer(), который принимает
     * экземпляр класса Dog и возвращает его сериализованное представление.
     * При сериализации необходимо использовать двоичное представление и MemoryStream.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
        }

        public static byte[] DogBinarySerializer(Dog dog)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(ms, dog);
                return ms.ToArray();
            }
        }
    }
}
