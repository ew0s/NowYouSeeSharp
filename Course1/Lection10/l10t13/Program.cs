using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l10t13
{
    /*
     * Создайте метод IsInDegree(), который:
     *      1) Принимает большое целое число в качестве входящего параметра.
     *      2) Возвращает логическое значение: true - если принятое число является числом 2 в целой степени и false если нет.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(IsInDegree(128));
            Console.WriteLine(IsInDegree(2));
            Console.WriteLine(IsInDegree(4));
            Console.WriteLine(IsInDegree(6));
            Console.WriteLine(IsInDegree(8));
            Console.WriteLine(IsInDegree(9));
            Console.WriteLine(IsInDegree(16));
            Console.WriteLine(IsInDegree(32));
            Console.WriteLine(IsInDegree(10));
            Console.WriteLine(IsInDegree(31));
            Console.WriteLine(IsInDegree(19));
        }

        /* Добавьте свой код ниже */
        public static bool IsInDegree(long value)
        {
            if (value == 1)
            {
                return true;
            }

            if (value % 2 == 0)
            {
                return IsInDegree(value / 2);
            }

            return false;
        }
    }
}
