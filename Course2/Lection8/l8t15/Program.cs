using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l8t15
{
    /*
     * Внутри метода Main() выведите в консоль всё содержимое файла SmallSampleFile.txt в одной строке,
     * используя соответствующий статический метод класса File.
     * 
     * При работе с файлом необходимо использовать абсолютный путь.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            string path = @"C:\Users\ew0s\Education\Course2\Lection8\l8t15\SmallSampleFile.txt";
            Console.WriteLine(File.ReadAllText(path));
        }
    }
}
