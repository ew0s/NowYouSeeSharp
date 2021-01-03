using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l10t15
{
    /*
     * Внутри метода Main():
     *      1) Объявите символьную переменную var1 и присвойте ей значение Й.
     *      2) Объявите символьную переменную var2 и присвойте ей значений Q.
     *      3) Объявите переменную var3 и присвойте ей значений суммы переменных var1 и var2 с использованием неявной типизации.
     *      4) Выведите на экран значение переменной var3.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            char var1 = 'Й';
            char var2 = 'Q';
            var var3 = var1 + var2;

            Console.WriteLine(var3);
        }
    }
}
