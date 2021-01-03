using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace l7t3
{
    /*
     * Для класса Program создайте публичный статический метод DeepCallMethod(), который должен вызывать сам
     * себя до тех пор, пока глубина рекурсии не достигнет 8, после чего в консоль должна вывестись фраза:
     * "Глубже - уже много =((". Перед каждым следующим вызовом, в консоль должна выводиться фраза
     * "Текущий уровень погружения: ХХХ", где ХХХ - порядковый номер глубины рекурсии, начиная с 1.
     * Внутри метода Main() запустите два отдельных потока для метода DeepCallMethod().
     */

    public class Program
    {
        [ThreadStatic] public static int RecursionLevel = 1;
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Thread thread1 = new Thread(DeepCallMethod);
            Thread thread2 = new Thread(DeepCallMethod);
            thread1.Start();
            thread2.Start();
        }

        public static void DeepCallMethod()
        {
            if (RecursionLevel == 8)
            {
                Console.WriteLine("Глубже - уже много =((");
                return;
            }

            Console.WriteLine($"Текущий уровень погружения: {RecursionLevel + 1}");
            RecursionLevel++;
            DeepCallMethod();
        }
    }
}
