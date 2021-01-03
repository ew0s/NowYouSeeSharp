using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l10t12
{
    /*
     * Реализуйте метод Swapper(), который:
     *      1) Принимает большое целое число в качестве входящего параметра.
     *      2) Если принятое число состоит только из нулей и единиц, то преобразует число следующим образом: все нули становятся единицами, а единицы нулями.
     *      3) Если принятое число 0 или отрицательное, то возвращает ноль.
     *      4) Во всех остальных случаях возвращет число, записанное задом наперед.
     * ======================================================================================================================================================
     *      Пример: получил 0 - вернул 0;
     *      Пример: получил -100 - вернул 0;
     *      Пример: получил 10000101 - вернул 01111010;
     *      Пример: получил 123 - вернул 321;
     * ======================================================================================================================================================
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Swapper(0));
            Console.WriteLine(Swapper(-100));
            Console.WriteLine(Swapper(1000101));
            Console.WriteLine(Swapper(123));
        }

        /* Добавьте свой код ниже */
        public static long Swapper(long number)
        {
            /* Добавьте свой код ниже */
            if (number <= 0)
            {
                return 0;
            }

            string returnString = "";

            foreach (char digit in number.ToString())
            {
                if (digit == '0')
                {
                    returnString += "1";
                }
                else if (digit == '1')
                {
                    returnString += "0";
                }
                else
                {
                    return Convert.ToInt64(new string(number.ToString().ToCharArray().Reverse().ToArray()));
                }
            }

            return Convert.ToInt64(returnString);
        }
    }
}
