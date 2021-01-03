using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l10t26
{
    /*
     * Значения переменных изменять нельзя.
     * Добавьте операции по преобразованию типов, чтобы на экран было выведено значение 9.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            short number = 9;
            char zero = '0';
            int nine = (zero + number);
            nine = Convert.ToInt32(Convert.ToChar(nine).ToString());
            Console.WriteLine(nine);
        }
    }
}
