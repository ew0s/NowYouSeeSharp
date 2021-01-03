using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace l6t1
{
    /*
     * Внутри класса Program создайте публичный статический метод Print(), который:
     *      1) Выводит в консоль значение числа 9 в 11 степени.
     *      2) Обладает сигнатурой, пригодной для запуска в отдельном потоке.
     * Внутри метода Main() запустите метод Print() в отдельном потоке.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Thread thread = new Thread(Print);
            thread.Start();
        }
        /* Добавьте свой код ниже */
        public static void Print()
        {
            Console.WriteLine(Math.Pow(9, 11));
        }
    }
}
