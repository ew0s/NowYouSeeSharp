using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace l8t5
{
    /*
     * Создайте статический метод SmartCreator(), который:
     *      1) Принимает в качестве входящего параметра имя файла.
     *      2) Ничего не возвращает.
     *      3) Создает в папке сборки текущего проекта новый пустой текстовый файл с указанным именем.
     * По завершении работы поток должен быть корректно закрыт.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            SmartCreator("Hello");
        }

        /* Добавьте свой код ниже */
        public static void SmartCreator(string fileName)
        {
            string path = @"C:\Users\ew0s\Education\Course2\Lection8\l8t5\bin\Debug\"+ fileName + ".txt";
            FileStream fs = File.Create(path);
            fs.Flush();
            fs.Close();
        }
    }
}
