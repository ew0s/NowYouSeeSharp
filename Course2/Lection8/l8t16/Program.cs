using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l8t16
{
    /*
     * Внутри метода Main() считайте все строчки файла CrazySampleFile.txt с использованием
     * соответствующего метода класса File, после чего последовательно выведите их в консоль, 
     * каждую с новой строки.
     * 
     * При работе с файлом необходимо использовать абсолютный путь.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            string path = @"C:\Users\ew0s\Education\Course2\Lection8\l8t16\CrazySampleFile.txt";
            var arr = File.ReadAllLines(path);
            foreach (var s in arr)
            {
                Console.WriteLine(s);
            }
        }
    }
}
