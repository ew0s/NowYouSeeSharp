using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l10t22
{
    /*
     * Добавьте 1 операцию по преобразованию типов, чтобы на экран было выведено значение 0.
     * Значения переменных изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            float f = (float)128.50;
            int i = (int)f;
            int b = (byte)(int)(i + f);
            Console.WriteLine(b);
        }
    }
}
