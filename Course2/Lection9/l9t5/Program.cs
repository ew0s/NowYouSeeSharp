using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace l9t5
{
    /*
     * Внутри класса Program создайте публичные статические методы:
     *      1) CatBinaryFileSerializer(), который принимает экземпляр класса Cat и возвращает его 
     *         сериализованное представление. 
     *      2) CatBinaryMemoryDeserializer(), который принимает сериализованное представление экземпляра класса
     *         Cat и возвращает его десериализованное представление.
     *      3) DogBinaryMemorySerializer(), который принимает экземпляр класса Dog и возвращает его 
     *         сериализованное представление. 
     *      4) DogBinaryFileDeserializer(), который принимает сериализованное представление экземпляра класса
     *         Dog и возвращает его десириализованное представление.
     * Логика и порядок десериализации каждого из создаваемых методов должны совпадать с логикой их именования.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Cat cat = new Cat {Age = 12, Name = "BOB"};
            Dog dog = new Dog {Age = 21, Name = "MOPS"};

            Cat newCat = CatBinaryMemoryDeserializer(CatBinaryFileSerializer(cat));
            Dog newDog = DogBinaryFileDeserializer(DogBinaryMemorySerializer(dog));

            Console.WriteLine(newDog.Age + " - " + newDog.Name);
            Console.WriteLine(newCat.Age + " - " + newCat.Name);
        }

        public static byte[] CatBinaryFileSerializer(Cat cat)
        {
            using (FileStream ms = new FileStream(@"C:\Users\ew0s\Education\Course2\Lection9\l9t5\Cat.bin", FileMode.OpenOrCreate))
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

        public static Cat CatBinaryMemoryDeserializer(byte[] byteCat)
        {
            using (MemoryStream ms = new MemoryStream(byteCat))
            {
                BinaryFormatter bf = new BinaryFormatter();
                return (Cat) bf.Deserialize(ms);
            }
        }

        public static byte[] DogBinaryMemorySerializer(Dog dog)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(ms, dog);
                return ms.ToArray();
            }
        }

        public static Dog DogBinaryFileDeserializer(byte[] byteDog)
        {
            using (FileStream fs = new FileStream(@"C:\Users\ew0s\Education\Course2\Lection9\l9t5\Dog.bin", FileMode.OpenOrCreate))
            {
                BinaryFormatter bf = new BinaryFormatter();

                foreach (var catByte in byteDog)
                {
                    fs.WriteByte(catByte);
                }
                fs.Position = 0;

                return (Dog) bf.Deserialize(fs);
            }
        }
    }
}
