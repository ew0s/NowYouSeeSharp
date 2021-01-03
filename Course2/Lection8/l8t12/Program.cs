using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l8t12
{
    /*
     * Для класса Program создайте и реализуйте публичные статические методы:
     *      1) CreateFile(), который:
     *         1.1) Принимает в качестве входящего параметра имя файла.
     *         1.2) Создаёт в папке сборки проекта пустой текстовый файл с указанным именем.
     *         1.3) Возвращает true в случае если файл был создан или false в случае если файл
     *              с таким именем уже существует.
     *      2) DeleteFile(), который:
     *         2.1) Принимает в качестве входящего параметра имя файла.
     *         2.2) Удаляет указанный файл из папки сборки проекта.
     *         2.3) Ничего не возвращает.
     * ============================================================================================
     *    В зависимости от текущих настроек Windows, есть вероятность, что  для корректной работы 
     *    программы придётся запустить Visual Studio в режиме администратора.
     * ============================================================================================
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            DeleteFile("Hello.txt");
        }

        public static bool CreateFile(string fileName)
        {
            if (Directory.Exists(fileName)) return false;
            var path = @"C:\Users\ew0s\Education\Course2\Lection8\l8t12\bin\Debug\" + fileName + ".txt";
            using (File.Create(path)){}

            return true;
        }

        public static void DeleteFile(string fileName)
        {
            var path = @"C:\Users\ew0s\Education\Course2\Lection8\l8t12\bin\Debug\" + fileName + ".txt";
            File.Delete(path);
        }
    }
}
