using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace l9t6
{
    /*
     * Внутри класса Program создайте и реализуйте четыре публичных статических метода, которые:
     *      1) Предоставляют возможность для двоичной сериализации и десериализации
     *         экземпляров класса Dog и Cat.
     *      2) Имеют имена CatSerializer\Deserializer и DogSerializer\Deserializer соответственно.
     * Для каждого из классов Dog и Cat переопределите метод ToString() так, чтобы он выводил
     * в консоль сведения об экземплярах класса в следующем формате:
     * "Я Котик\Собачка по имени ХХХ и мне YYY лет!", где ХХX и YYY значения 
     * соответствующих полей классов.
     * Реализуйте логику десериализаторов таким образом, чтобы все десериализованные объекты
     * стали обладать вдвое большим возрастом, чем изначально имели.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Dog dog = new Dog {Age = 2, Name = "BOB"};
            Cat cat = new Cat {Age = 4, Name = "DOOOM"};

            Dog newDog = DogDeserializer(DogSerializer(dog));
            Cat newCat = CatDeserializer(CatSerializer(cat));

            Console.WriteLine(newDog.Age + " - " + newDog.Name);
            Console.WriteLine(newCat.Age + " - " + newCat.Name);

        }

        public static byte[] CatSerializer(Cat cat)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(ms, cat);
                return ms.ToArray();
            }
        }

        public static Cat CatDeserializer(byte[] byteCat)
        {
            using (MemoryStream ms = new MemoryStream(byteCat))
            {
                BinaryFormatter bf = new BinaryFormatter();
                Cat newCat = (Cat) bf.Deserialize(ms);
                newCat.Age *= 2;
                return newCat;
            }
        }

        public static byte[] DogSerializer(Dog dog)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(ms, dog);
                return ms.ToArray();
            }
        }

        public static Dog DogDeserializer(byte[] byteDog)
        {
            using (MemoryStream ms = new MemoryStream(byteDog))
            {
                BinaryFormatter bf = new BinaryFormatter();
                Dog newDog = (Dog) bf.Deserialize(ms);
                newDog.Age *= 2;
                return newDog;
            }
        }
    }
}
