using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l8t4
{
    /*
     * Внутри метода Main() создайте подходящий поток для чтения данных из файла FileSample.txt, после 
     * чего выведите в консоль содержимое считанного файла с новой строки.
     * 
     * При работе с файлом должен использоваться абсолютный путь.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */

            try
            {
                string str = File.ReadAllText(@"C:\Users\ew0s\Education\Course2\Lection8\l8t4\FileSample.txt");
                Console.WriteLine(str);
            }
            catch (Exception)
            {
                Console.WriteLine();
                throw;
            }
        }
    }
}
