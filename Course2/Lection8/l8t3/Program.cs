using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l8t3
{
    /*
     * Внутри метода Main() создайте подходящий поток для чтения данных из файла FileSample.txt, после 
     * чего выведите в консоль каждый байт считанного файла с новой строки.
     * 
     * При работе с файлом должен использоваться абсолютный путь.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            var fs = new FileStream(@"C:\Users\ew0s\Education\Course2\Lection8\l8t3\FileSample.txt", FileMode.Open);
            int i;

            try
            {
                do
                {
                    i = fs.ReadByte();
                    if (i != -1) Console.WriteLine(i);
                } while (i != -1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                fs.Close();
            }

        }
    }
}
