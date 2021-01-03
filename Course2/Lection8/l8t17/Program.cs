using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l8t17
{
    /*
     * Внутри метода Main() считайте все байты файла CodeSample.txt с использованием соответствующего
     * метода класса File, после чего выведите в консоль длину получившегося массива байт.
     * 
     * При работе с файлом необходимо использовать абсолютный путь.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            string path = @"C:\Users\ew0s\Education\Course2\Lection8\l8t17\CodeSample.txt";
            var arr = File.ReadAllBytes(path);
            Console.WriteLine(arr.Length);
        }
    }
}
