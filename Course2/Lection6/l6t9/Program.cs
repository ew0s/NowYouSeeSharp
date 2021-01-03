using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace l6t9
{
    /*
     * Внутри класса Program создайте публичный статический метод StartCount(), который должен выводить в консоль
     * числа от -1000 до 0 включительно.
     * Внутри метода Main() запустите метод StartCount() в отдельном потоке, после чего начните выводить в консоль
     * числа от 1000 до 0 включительно.
     * Полюбуйтесь полученным сумбуром =)
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Thread thread = new Thread(StartCount);
            thread.Start();

            for (int i = 1000; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static void StartCount()
        {
            for (int i = -1000; i <= 0; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
