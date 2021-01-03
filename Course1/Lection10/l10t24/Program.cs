using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l10t24
{
    /*
     * Добавьте 1 операцию по преобразованию типов, чтобы на экран было выведено значение 5.5.
     * Значения переменных изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            int a = 5;
            int b = 4;
            int c = 3;
            int e = 2;
            double d = a + b / c / (double)e;
            Console.WriteLine(d);
        }
    }
}
