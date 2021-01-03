using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace l6t12
{
    /*
     * Внутри метода Main() реализуйте таймер с обратным отчетом от 5 до 0 с выводом текущего
     * значения таймера в консоль, каждое значение с новой строки. 
     * Таймер должен тикать с интервалом в 1 секунду, а окончания отсчета в консоль должна
     * вывестись фраза "Бабах".
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            for (int i = 5; i >= 0; i --)
            {
                Thread.Sleep(1000);
                Console.WriteLine(i);
            }

            Console.WriteLine("Бабах");
        }
    }
}
