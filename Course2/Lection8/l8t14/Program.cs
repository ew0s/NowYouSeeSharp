using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l8t14
{
    /*
     * Создайте публичный статический метод ReadFileWithBuff(), который:
     *      1) Ничего не принимает и считывает информацию из файла SampleFile.txt, 
     *         расположенном в корневой директории проекта.
     *      2) При считывании должен использоваться дополнительный буферизированный поток, который будет
     *         использовать FileStream в качестве опорного хранилища.
     *      3) Устанавливает размер буфера равный 1024 битам, при инстанциировании потока.
     *      4) Возвращает строковое представление тех данных, что были прочитаны из файла.
     * Внутри метода Main() запустите метод ReadFileWithBuffer() и выведите в консоль результат его работы.
     * 
     * При работе программы используйте абсолютный путь до файла.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Console.WriteLine(ReadFileWithBuff());
        }

        public static string ReadFileWithBuff()
        {
            string path = @"C:\Users\ew0s\Education\Course2\Lection8\l8t14\SampleFile.txt";
            string output = "";

            using (FileStream fs = File.OpenRead(path))
            {
                using (BufferedStream bf = new BufferedStream(fs, 128))
                {
                    output += File.ReadAllText(path);
                }
            }

            return output;
        }
    }
}
