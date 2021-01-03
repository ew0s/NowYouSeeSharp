using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l8t11
{
    /*
     * Проведите рефакторинг метода Main() таким образом, чтобы при работе с созданными
     * в нём потоками ввода-вывода высвобождались все задействованные ресурсы без вызова
     * методов Close() и использования конструкции try-catch-finally.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            using (FileStream fs = new FileStream("Easy.txt", FileMode.OpenOrCreate))
            {
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    Console.WriteLine(bs.CanSeek);
                    Console.WriteLine(fs.CanSeek);
                    Console.WriteLine(bs.CanTimeout);
                    Console.WriteLine(fs.CanTimeout);
                }
            }
        }
    }
}
