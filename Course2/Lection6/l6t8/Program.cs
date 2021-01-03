using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace l6t8
{
    /*
     * Для класса Program создайте 3 публичных статических переменные, которые:
     *      1) Называются resultX, где Х - порядковый номер переменной.
     *      2) Имеют тип больших неотрицательных целочисленных значений.
     * Внутри класса Program создайте 3 публичных статических метода:
     *      1) Method1 должен возвращать в переменную result1 значение факториала числа, полученного 
     *         в качестве аргумента.
     *      2) Method2 должен возвращать в переменную result2 значение квадрата числа, полученного 
     *         в качестве аргумента.
     *      3) Method3 должен возвращать в переменную result3 значение куба числа, полученного 
     *         в качестве аргумента.
     * Внутри метода Main() создайте 3 потока, по 1 для каждого из созданных методов и запустите их, считав с 
     * клавиатуры числа, для каждого из запускаемых потоков.
     */

    public class Program
    {
        public static ulong result1;
        public static ulong result2;
        public static ulong result3;

        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Thread thread1 = new Thread(Method1);
            Thread thread2 = new Thread(Method2);
            Thread thread3 = new Thread(Method3);

            thread1.Start(Convert.ToInt32(Console.ReadLine()));
            thread2.Start(Convert.ToInt32(Console.ReadLine()));
            thread3.Start(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
        }
        /* Добавьте свой код ниже */

        public static void Method1(object value)
        {
            ulong res = 1;
            var number = Convert.ToInt32(value);

            if (number > 1)
            {
                for (var i = (ulong) number; i > 1; i--)
                {
                    res *= i;
                }
            }

            result1 = res;
        }

        public static void Method2(object value)
        {
            result2 = (ulong) Math.Pow((int) value, 2);
        }

        public static void Method3(object value)
        {
            result3 = (ulong) Math.Pow((int) value, 3);
        }
    }
}
