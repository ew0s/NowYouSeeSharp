using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l10t3
{
    /*
     * Измените шаблон задачи таким образом, чтобы все типы переменных внутри метода Main() были заданы неявно.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            var a = 1;
            var b = " работа ";
            var c = "void безделья";
            var d = " бедняга ";
            var e = "%USERNAME% ";
            var f = "не знает веселья";
            var l = a * 9999;

            for (var i = 0; i < l; i++)
            {
                Console.WriteLine(a + b + c + d + e + f);
            }
        }
    }
}
