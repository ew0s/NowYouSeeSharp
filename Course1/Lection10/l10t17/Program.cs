using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l10t17
{
    /*
     * Внутри метода Main() объявите две символьные переменные А и Z. Переменной А присвойте минимально возможное значение, а Z - максимально возможное.
     * Выведите на экран значение переменных A и Z, каждое с новой строки.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            char A = char.MinValue;
            char Z = char.MaxValue;

            Console.WriteLine(A);
            Console.WriteLine(Z);
        }
    }
}
