using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l8t20
{
    /*
     * Создайте публичный статический метод CheckIsFileExist(), который:
     *      1) Принимает полный путь к искомому файлу.
     *      2) Возвращает true, если файл существует, и false если не существует.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
        }

        public static bool CheckIsFileExist(string path)
        {
            return File.Exists(path);
        }
    }
}
