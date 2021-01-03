using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace l7t9
{
    /*
     * Внутри метода Main() запустите 100 раз каждый из методов Work() и Fun() в отдельных потоках.
     * Синхронизируйте потоки таким образом, чтобы вывод в консоль всегда осуществлялся корректно.
     */

    public class Program
    {
        public static object MagicBall = new object();
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            for (int i = 0; i < 100; i++)
            {
                var thread1 = new Thread(Work);
                var thread2 = new Thread(Fun);
                thread1.Start();
                thread1.Join();
                thread2.Start();
                thread2.Join();
            }
        }

        public static void Work()
        {
            lock (MagicBall)
            {
                Console.Write("Одна");
                Console.Write(" ");
                Console.Write("работа");
                Console.Write(",");
                Console.Write(" ");
                Console.Write("никакого");
                Console.Write(" ");
                Console.Write("безделья");
                Console.Write(" ");
                Console.Write("...");
                Console.WriteLine();   
            }
        }

        public static void Fun()
        {
            lock (MagicBall)
            {
                Console.Write("Бедняга");
                Console.Write(" ");
                Console.Write("Джек");
                Console.Write(" ");
                Console.Write("не");
                Console.Write(" ");
                Console.Write("знает");
                Console.Write(" ");
                Console.Write("веселья");
                Console.Write("!");
                Console.WriteLine();   
            }
        }
    }
}
