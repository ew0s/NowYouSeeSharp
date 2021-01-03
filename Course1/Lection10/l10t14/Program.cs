using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace l10t14
{
    /*
     * Реализуйте метод BigIntegerCalculator(), который:
     *      1) Принимает два больших целых числа в качестве входящих параметров.
     *      2) Возвращает строку, содержащую сумму принятых больших целых чисел.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            long a =  9000000000000000000;
            long b =  9000000000000000000;
            Console.WriteLine(BigIntegerCalculator(a, b));

        }

        public static string BigIntegerCalculator(long lValue, long rValue)
        {
            if (lValue > 0 && rValue > 0)
            {
                return (Convert.ToUInt64(lValue) + Convert.ToUInt64(rValue)).ToString();
            }

            return (lValue + rValue).ToString();
        }
    }
}
