using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l10t1
{
    /*
     * Внутри метода Main() объявите две переменные х и у с использованием неявной типизации. Присвойте переменной х значение - 300, а переменной y значение - КРАСОТА.
     * Выведите на экран результат сложения переменной х и у.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            var x = 300;
            var y = "КРАСОТА";

            Console.WriteLine(x + y);
        }
    }
}
