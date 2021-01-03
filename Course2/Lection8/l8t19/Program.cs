using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l8t19
{
    /*
     * Внутри метода Main() создайте новый экземпляр класса FileStream в режиме создания нового файла.
     * Создаваемый в стриме файл назовите example.txt (он должен быть в папке сборки проекта), после чего:
     *      1) Создайте новый экземпляр StreamWriter использующий созданный поток FileStream в качестве
     *         опорного хранилища.
     *      2) Запишите в поток фразу "Halli-Hallo!".
     *      3) Выведите в консоль все содержимое потока FileStream, каждое значение с новой строки.
     * Создавать дополнительные потоки ввода-вывода запрещено.
     * 
     * При создании файла используйте абсолютный путь.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            string path = @"C:\Users\ew0s\Education\Course2\Lection8\l8t19\bin\Debug\example.txt";

            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write("Halli-Hallo!");
                }

                var arr = File.ReadAllBytes(path);
                foreach (var b in arr)
                {
                    Console.WriteLine(b);
                }
            }
        }
    }
}
