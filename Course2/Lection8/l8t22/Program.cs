using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace l8t22
{
    /*
     * В отдельном файле создайте класс Cat, который должен содержать:
     *      1) 3 публичный свойства, отвечающих за имя, возраст и вес. Типы данных определите самостоятельно.
     *      2) Конструктор, который последовательно принимает и устанавливает значения соответствующих свойств
     *         для создаваемого экземпляра класса.
     *      3) Метод ToString(), который должен возвращать строковое представление экземпляра класса в формате:
     *         "XXX&&YYY&&ZZZ", где XXX YYY ZZZ - значения имени, возраста и веса экземпляра класса соответственно.
     * Внутри класса Program создайте публичный статический метод MakeArrayFromCat(), который:
     *      1) Принимает экземпляр класса Cat в качестве входящего параметра.
     *      2) Преобразует полученный экземпляр класса к массиву байт и возвращает его.
     * Внутри класса Program создайте публичный статический метод MakeCatFromArray(), который:
     *      1) Принимает массив байт в качестве входящего параметра.
     *      2) Производит манипуляции с полученным массивом байт таким образом, чтобы извлечь из него хранимого
     *         там экземпляра класса Cat и возвращает этот экземпляр.
     * Использовать стандартные форматтеры для сериализации нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            var cat = new Cat("BOBIK", 12, 12312);
            var arr = MakeArrayFromCat(cat);
            var newCat = MakeCatFromArray(arr);

            Console.WriteLine(newCat);
        }

        public static Cat MakeCatFromArray(byte[] byteArr)
        {
            var catAsStr = Encoding.UTF8.GetString(byteArr);
            var catsValues = catAsStr.Split('&').ToList();
            catsValues.RemoveAll(value => value == "");

            return new Cat(catsValues[0], int.Parse(catsValues[1]), int.Parse(catsValues[2]));
        }

        public static byte[] MakeArrayFromCat(Cat cat)
        {
            return cat == null ? null : Encoding.UTF8.GetBytes(cat.ToString());
        }
    }
}
