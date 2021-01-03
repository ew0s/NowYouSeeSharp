using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l8t29
{
    /*
     * Внутри проекта задачи лежит 4 файла:
     *      1) Integers.txt
     *      2) Symbols.txt
     *      3) SmallStrings.txt
     *      4) BigStrings.txt
     * Создайте публичный статический асинхронный метод WordSorter(), который:
     *      1) Принимает число Х в качестве входящего параметра.
     *      2) Считывает с консоли строки Х раз, после чего распределяет их по соответствующим файлам
     *         исходя из логики их названия. Большой строкой должна считаться строка из 50 и более символов.
     *      3) Ничего не возвращает.
     *      4) Каждый раз запуске работы метода, он должен очищать все имеющиеся данные внутри файлов и только
     *         после этого производить запись.
     * При работе с файлами используйте абсолютный путь.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            WordSorter(10);
        }

        public static async void WordSorter(int X)
        {
            using (File.Create(@"C:\Users\ew0s\Education\Course2\Lection8\l8t29\BigStrings.txt")) {}
            using (File.Create(@"C:\Users\ew0s\Education\Course2\Lection8\l8t29\Integers.txt")) {}
            using (File.Create(@"C:\Users\ew0s\Education\Course2\Lection8\l8t29\SmallStrings.txt")) {}
            using (File.Create(@"C:\Users\ew0s\Education\Course2\Lection8\l8t29\Symbols.txt")) {}

            for (int i = 0; i < X; i++)
            { 
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input)) continue; 
                if (int.TryParse(input, out _))
                {
                    WriteFile(@"C:\Users\ew0s\Education\Course2\Lection8\l8t29\Integers.txt", input);
                }
                else if (input.Length >= 50)
                {
                    WriteFile(@"C:\Users\ew0s\Education\Course2\Lection8\l8t29\BigStrings.txt", input);
                }
                else if (input.Length == 1 && char.IsSymbol(input[0]))
                {
                    WriteFile(@"C:\Users\ew0s\Education\Course2\Lection8\l8t29\Symbols.txt", input);
                }
                else
                {
                    WriteFile(@"C:\Users\ew0s\Education\Course2\Lection8\l8t29\SmallStrings.txt", input);
                }
            }
        }

        public static void WriteFile(string path, string value)
        {
            using (var fs = new FileStream(path, FileMode.Append))
            {
                using (var sw = new StreamWriter(fs))
                {
                    sw.WriteLine(value);
                }
            }
        }
    }
}
