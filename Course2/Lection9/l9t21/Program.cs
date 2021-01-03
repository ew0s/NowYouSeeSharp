using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace l9t21
{
    /*
     * Внутри класса Program создайте публичный статический метод CatJSONDeserializer(), который принимает 
     * сериализованное JSON представление класса Cat и возвращает его в виде соответствующего экземляра класса.
     * Для десериализации используйте библиотеку Newtonsoft.Json
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
        }

        public static Cat CatJSONDeserializer(string JSONCat)
        {
            return JsonConvert.DeserializeObject<Cat>(JSONCat);
        }
    }
}
