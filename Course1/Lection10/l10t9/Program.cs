using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l10t9
{
    /*
     * Для всех неявно типизированных переменных шаблона, установите оптимальные типы на основе ожидаемого диапазона значений переменной из комментария к ней.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            short value1 = 17;  // Не будет превышать 30 тысяч
            int value2 = -10; // Не будет превышать 1 млн.
            long value3 = 10;  // Не будет превышать 3 млрд.
            sbyte value4 = -10; // Не будет превышать 100
            ushort value5 = 10;  // Не будет превышать 60 тысяч, не может быть отрицательным
            uint value6 = 17;  // Не будет превышать 3 млрд., не может быть отрицательным
            byte value7 = 17;  // Не будет превышать 100, не может быть отрицательным
        }
    }
}
