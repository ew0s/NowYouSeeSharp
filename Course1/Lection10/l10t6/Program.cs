using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l10t6
{
    /*
     * Проанализируйте шаблон и для всех переменных метода Main(), значения которых могут быть помещены в тип byte, задайте его явно.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            byte value1 = 201;
            var value2 = 0x01C9;
            byte value3 = 0b1100_1001;
            byte value4 = 0x00C0;
            var value5 = 123138;
            var value6 = 256;
            var value7 = 0.25;
            byte value8 = 0b1111_1111;
            byte value9 = 0;
            var value10 = 100_1001;
        }
    }
}
