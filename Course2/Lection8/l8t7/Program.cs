using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l8t7
{
    /*
     *  Создайте статический метод Repeater(), который:
     *      1) Принимает в качестве входящего параметра имя файла.
     *      2) Ничего не возвращает.
     *      3) Считывает 10 строк с клавиатуры.
     *      3) Создает в папке сборки текущего проекта новый текстовый файл с указанным именем и
     *         записывает в него самую длинную считанную строку такое количество раз, которое
     *         равно длине самой маленькой из считанных строк.
     *  По завершению работы поток должен быть корректно закрыт.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Repeater("Hello");
        }

        public static void Repeater(string fileName)
        {
            FileStream fs = File.Create(@"C:\Users\ew0s\Education\Course2\Lection8\l8t7\bin\Debug\" + fileName + ".txt");

            string largestString = "";
            int shortestStringLength = Int32.MaxValue;

            for (int i = 0; i < 10; i++)
            {
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input) && string.IsNullOrWhiteSpace(input)) continue;
                if (input.Length < shortestStringLength) shortestStringLength = input.Length;
                if (input.Length > largestString.Length) largestString = input;
            }

            var arr = new byte[largestString.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (byte) largestString[i];
            }

            try
            {
                for (int i = 0; i < shortestStringLength; i++)
                {
                    fs.Write(arr, 0, arr.Length);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
            finally
            {
                fs.Close();
            }
        }
    }
}
