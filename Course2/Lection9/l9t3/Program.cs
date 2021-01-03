using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace l9t3
{
    /*
     * Внутри класса Program создайте публичный статический метод CatBinarySerializer(), который принимает
     * экземпляр класса Cat и возвращает его сериализованное представление.
     * При сериализации необходимо использовать двоичное представление и FileStream.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
        }

        public static byte[] CatBinarySerializer(Cat cat)
        {
            using (FileStream ms = new FileStream(@"C:\Users\ew0s\Education\Course2\Lection9\l9t3\Cat.bin", FileMode.OpenOrCreate))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(ms, cat);
                ms.Position = 0;
                List<byte> catByte = new List<byte>();
                int i;
                do
                {
                    i = ms.ReadByte();
                    if (i != -1)
                    {
                        catByte.Add((byte)i);
                    }
                }
                while (i != -1);

                return catByte.ToArray();
            }
        }
    }
}
