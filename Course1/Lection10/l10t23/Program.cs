using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l10t23
{
    /*
     * Расставьте правильно операции преобразования примитивных типов, чтобы на экран было выведено значение 256.
     * Значения переменных изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            int a = (byte)44;
            int b = 300;
            short c = (short)(b - a);
            Console.WriteLine(c);
        }
    }
}
