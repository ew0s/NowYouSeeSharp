using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l10t1
{
    /*
     * Внутри класса Program создайте публичный делегат, который бы соответствовал 
     * следующей формальной логике:
     *      1) Принимал большое целое число и строку в качестве входящего параметра.
     *      2) Ничего не возвращал.
     *      3) Имел имя Operation.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            
        }

        public delegate void Operation(long numb, string str);
    }
}
