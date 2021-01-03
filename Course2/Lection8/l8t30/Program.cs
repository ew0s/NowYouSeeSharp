using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace l8t30
{
    /*
     * Создайте и реализуйте публичный статический метод SmartReplaсer(), который:
     *      1) Принимает в качестве входящих параметров 3 строки:
     *         1.1) Исходная строка.
     *         1.2) Новая строка.
     *         1.3) Путь до целевого файла.
     *      2) Ищет и заменяет в целевом файле все вхождения исходной строки на значения новой.
     *      3) Возвращает список строк, содержащий все заменённые строки из исходного файла.
     * При поиске строк в целевом файле регистр не должен учитываться.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            var arr = SmartReplacer("in", "HOPA_JOPA", @"C:\Users\ew0s\Education\Course2\Lection8\l8t30\EpicStory.txt");
            foreach (var VARIABLE in arr)
            {
                Console.WriteLine(VARIABLE);
            }
        }

        public static List<string> SmartReplacer(string oldStr, string newStr, string path)
        {
            var collection = File.ReadAllText(path);
            var value = Regex.Replace(oldStr, newStr, @"$$0", RegexOptions.IgnoreCase);
            Console.WriteLine(value);


            return null;
        }
    }
}
