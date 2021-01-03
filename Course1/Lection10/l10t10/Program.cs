using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l10t10
{
    /*
    * Проанализируйте логику работы программы и внесите изменения так, чтобы диапазон рабочих значений программы изменился в большую сторону,
    * а вывод в консоль стал корректным. Содержимое метода Main() изменять нельзя.
    */

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Факториал числа 0 равен: " + OMGItsFactorialAgain(0));
            Console.WriteLine("Факториал числа 1 равен: " + OMGItsFactorialAgain(1));
            Console.WriteLine("Факториал числа 5 равен: " + OMGItsFactorialAgain(5));
            Console.WriteLine("Факториал числа 7 равен: " + OMGItsFactorialAgain(7));
            Console.WriteLine("Факториал числа 10 равен: " + OMGItsFactorialAgain(10));
            Console.WriteLine("Факториал числа 12 равен: " + OMGItsFactorialAgain(12));
            Console.WriteLine("Факториал числа 15 равен: " + OMGItsFactorialAgain(15));
            Console.WriteLine("Факториал числа 17 равен: " + OMGItsFactorialAgain(17));
            Console.WriteLine("Факториал числа 20 равен: " + OMGItsFactorialAgain(20));
        }

        /* Добавьте свой код ниже */
        public static long OMGItsFactorialAgain(long x)
        {
            if (x == 0 || x == 1)
            {
                return 1;
            }
            return x * OMGItsFactorialAgain(x - 1);
        }
    }
}
