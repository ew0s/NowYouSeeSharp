using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l10t25
{
    /*
     * Расставьте правильно операции преобразования примитивных типов, чтобы на экран было выведено значение 1000.
     * Значения переменных изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            double d = (byte)2.50256e2d;
            char c = 'd';
            short s = (short)2.22;
            int i = 150000;
            float f = 0.50f;
            double result = f + (i / c) - (d * s) - 500e-3;
            Console.WriteLine(result);
        }
    }
}
