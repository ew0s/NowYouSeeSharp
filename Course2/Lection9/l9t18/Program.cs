using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace l9t18
{
    /*
     * Внутри класса Program создайте и реализуйте два публичных статических метода, которые:
     *      1) Предоставляют возможность для XML сериализации и десериализации
     *         экземпляра класса Dog в файл соответствующего формата.
     *      2) Имеют имена DogSerializer и DogDeserializer соответственно.
     *      3) Первым атрибутом метод DogSerializer должен принимать путь до файла, в который будет
     *         помещаться сериализованное представление объекта, а вторым сам объект сериализации.
     *      4) Метод DogDeserializer() должен принимать путь до файла, из которого будет извлекаться
     *         и возвращаться десериализованный экземпляр соответствующего класса.
     *      5) Метод DogSerializer() ничего не должен возвращать.
     * Для класса Dog переопределите метод ToString() так, чтобы он выводил в консоль сведения 
     * об экземплярах класса в следующем формате:
     * "Грустно собачке ХХХ жить YYY лет в XML, но выбора нет...", где ХХX и YYY значения 
     * соответствующих полей класса.
     * Реализуйте логику десериализаторов таким образом, чтобы все десериализованные объекты
     * всегда обладали именем с префиксом "Deserialized_".
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Dog dog = new Dog {Age = 12, Name = "BOBIK"};
            DogSerializer(Directory.GetCurrentDirectory() + "\\dogXml.xml", dog);
            Dog newDog = DogDeserializer(Directory.GetCurrentDirectory() + "\\dogXml.xml");
            Console.WriteLine(newDog.Name);
        }

        public static void DogSerializer(string filePath, Dog dog)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Dog));
                xmlSerializer.Serialize(fs, dog);
            }
        }

        public static Dog DogDeserializer(string filePath)
        {
            if (!File.Exists(filePath)) return null;

            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Dog));
                Dog newDog = (Dog) xmlSerializer.Deserialize(fs);
                newDog.Name = "Deserialized_" + newDog.Name;
                return newDog;
            }
        }
    }
}
