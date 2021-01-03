using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l8t6
{
    /*
     *  Создайте статический метод CreateEmptyFile(), который:
     *      1) Принимает в качестве входящего параметра имя файла и его размер в байтах.
     *      2) Ничего не возвращает.
     *      3) Создает в папке сборки текущего проекта новый пустой текстовый файл с указанным именем
     *         и размером.
     *  По завершению работы поток должен быть корректно закрыт.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            CreateEmptyFile("Hello", 1000000);
        }

        public static void CreateEmptyFile(string fileName, int size)
        {
            string path = @"C:\Users\ew0s\Education\Course2\Lection8\l8t6\bin\Debug\"  + fileName + ".txt";
            FileStream fs = File.Create(path);
            fs.SetLength(size);
            fs.Close();
        }
    }
}
