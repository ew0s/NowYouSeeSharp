using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileStream = System.IO.FileStream;

namespace l8t13
{
    /*
     * Для класса Program создайте и реализуйте публичные статические методы:
     *      1) CreateFile(), который:
     *         1.1) Принимает в качестве входящего параметра имя файла.
     *         1.2) Создаёт в папке сборки проекта пустой текстовый файл с указанным именем.
     *         1.3) Возвращает true в случае если файл был создан или false в случае если файл
     *              с таким именем уже существует.
     *      2) UpdateFile(), который:
     *         2.1) Принимает в качестве входящего параметра имя файла, расположенного в папке 
     *              сборки проекта.
     *         2.2) Ничего не возвращает.
     *         2.3) Считывает с клавиатуры строку и записывает её в указанный текстовый файл.
     *         2.4) В случае если файла не существует - вызывает метод CreateFile(), после чего
     *              записывает в него считанную строку.
     *      3) DeleteFile(), который:
     *         3.1) Принимает в качестве входящего параметра имя файла.
     *         3.2) Удаляет указанный файл из папки сборки проекта.
     *         3.3) Ничего не возвращает.
     *      4) ReadFile(), который:
     *         4.1) Принимает в качестве входящего параметра имя файла, расположенного в папке 
     *              сборки проекта.
     *         4.2) Считывает всё содержимое файла и выводит его в консоль.
     *         4.3) Ничего не возвращает.
     *        
     * ============================================================================================
     *    В зависимости от текущих настроек Windows, есть вероятность, что для корректной работы 
     *    программы придётся запустить Visual Studio в режиме администратора.
     * ============================================================================================
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            UpdateFile("Hello");
        }

        public static bool CreateFile(string fileName)
        {
            var path = @"C:\Users\ew0s\Education\Course2\Lection8\l8t13\bin\Debug\" + fileName + ".txt";
            if (File.Exists(path)) return false;
            using (new FileStream(path, FileMode.Create))
            {}

            return true;
        }

        public static void DeleteFile(string fileName)
        {
            var path = @"C:\Users\ew0s\Education\Course2\Lection8\l8t13\bin\Debug\" + fileName + ".txt";
            File.Delete(path);
        }

        public static void UpdateFile(string fileName)
        {
            var input = Console.ReadLine();
            var path = @"C:\Users\ew0s\Education\Course2\Lection8\l8t13\bin\Debug\" + fileName + ".txt";

            if (File.Exists(path))
            {
                using (var sw = File.AppendText(path))
                {
                    sw.Write(input);
                }
            }
            else
            {
                CreateFile(fileName);
                if (string.IsNullOrEmpty(input) && string.IsNullOrWhiteSpace(input)) return;
                using (var sw = File.AppendText(path))
                {
                    sw.Write(input);
                }
            }
        }

        public static void ReadFile(string fileName)
        {
            var path = @"C:\Users\ew0s\Education\Course2\Lection8\l8t13\bin\Debug\" + fileName + ".txt";
            Console.WriteLine(File.ReadAllText(path));
        }
    }
}
