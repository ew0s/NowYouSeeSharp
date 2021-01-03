using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l10t7
{
    /*
     * Проанализируйте шаблон и для всех переменных метода Main(), значения которых могут быть помещены в тип short, задайте его явно.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            short value1 = 31101;
            short value2 = 0x01C9;
            short value3 = 0b1100_1001;
            var value4 = 32769;
            var value5 = 123138;
            short value6 = 256;
            var value7 = -32788;
            short value8 = 0b1111_1111;
            short value9 = 0;
            var value10 = 100_101;
        }
    }
}
