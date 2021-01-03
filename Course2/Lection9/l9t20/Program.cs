using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace l9t20
{
    /*
     * Внутри класса Program создайте публичный статический метод CatJSONSerializer(), который принимает
     * экземпляр класса Cat и возвращает его сериализованное JSON представление.
     * Для сериализации используйте библиотеку Newtonsoft.Json
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
        }

        public static string CatJSONSerializer(Cat cat)
        {
            using (StringWriter sw = new StringWriter())
            {
                JsonSerializer js = new JsonSerializer();
                js.Serialize(sw, cat);
                return sw.ToString();
            }
        }
    }
}
