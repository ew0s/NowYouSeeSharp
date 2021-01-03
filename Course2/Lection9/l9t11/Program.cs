using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;

namespace l9t11
{
    /*
     * Внутри класса Program создайте и реализуйте два публичных статических метода, которые:
     *      1) Предоставляют возможность для SOAP сериализации и десериализации
     *         экземпляра класса Dog в файл соответствующего формата.
     *      2) Имеют имена DogSerializer и  DogDeserializer соответственно.
     *      3) Первым атрибутом метод DogSerializer должен принимать путь до файла, в который будет
     *         помещаться сериализованное представление объекта, а вторым сам объект сериализации.
     *      4) Метод DogDeserializer() должен принимать путь до файла, из которого будет извлекаться
     *         и возвращаться десериализованный экземпляр соответствующего класса.
     *      5) Метод DogSerializer() ничего не должен возвращать.
     * Реализуйте логику сериализации таким образом, чтобы все сериализованные объекты
     * всегда обладали именем с постфиксом "_NotSoFreshByStillHotDog".
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            DogSerializer(Directory.GetCurrentDirectory() + "\\serializedDog.soap", new Dog {Name = "BOBIK", Weight = 123});
            Dog newDog = DogDeserializer(Directory.GetCurrentDirectory() + "\\serializedDog.soap");

            Console.WriteLine(newDog.Name);
        }

        public static void DogSerializer(string filePath, Dog dog)
        {
            dog.Name += "_NotSoFreshByStillHotDog";
            
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(fs, dog);
            }
        }

        public static Dog DogDeserializer(string filePath)
        {
            if (!File.Exists(filePath)) return null;

            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                SoapFormatter sf = new SoapFormatter();
                return (Dog) sf.Deserialize(fs);
            }
        }
    }
}
