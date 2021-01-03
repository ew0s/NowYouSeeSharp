using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace l6t2
{
    /*
     * Внутри класса Program создайте публичный статический метод Print(), который:
     *      1) Принимает целочисленный параметр n в качестве входящего параметра.
     *      2) Выводит в консоль значение числа 9 в степени n.
     * Внутри метода Main() запустите метод Print() в отдельном потоке так, чтобы
     * требуемая степень числа считывалась с клавиатуры.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Thread thread = new Thread(Print);
            thread.Start(Convert.ToInt32(Console.ReadLine()));
        }

        public static void Print(object n)
        {
            Console.WriteLine(Math.Pow(9, (int) n));
        }
    }
}
