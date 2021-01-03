using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;

namespace l9t10
{
    /*
     * Внутри класса Program создан статический массив экземпляров класса Animal.
     * Внутри метода Main() реализуйте логику сериализации и хранения этого массива
     * в SOAP формате.
     * Файл с сохраненным представлением должен называться AllAnimals и иметь soap формат.
     * Файл должен располагаться в папке сборки проекта.
     * При работе с файлами используйте абсолютный путь.
     */

    public class Program
    {
        public static Animal[] animals =
        {
            new Animal() {Name = "Котик", Age=12, Description = "Красивый котик" },
            new Animal() {Name = "Собачка", Age=13, Description = "Красивая собачка" },
            new Animal() {Name = "Птичка", Age=14, Description = "Птичка-синичка" },
            new Animal() {Name = "Синичка", Age=15, Description = "Птичка-птичка" },
            new Animal() {Name = "Черепашка", Age=16, Description = "По имени Наташка" },
            new Animal() {Name = "Мышка", Age=17, Description = "Mr.Mouse" },
        };

        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            using (FileStream fs = new FileStream(@"C:\Users\ew0s\Education\Course2\Lection9\l9t10\bin\Debug\AllAnimals.soap", FileMode.Create))
            {
                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(fs, animals);
            }
        }
    }
}
