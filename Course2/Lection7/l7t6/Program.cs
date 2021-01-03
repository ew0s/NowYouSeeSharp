using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace l7t6
{
    /*
     * Метод SmallCalc() предполагается использовать в нескольких потоках сразу.
     * Сделайте так, чтобы доступ ко всему телу метода был одновременно доступен лишь одному потоку.
     */

    public class Program
    {
        public static object MagicBall = new object();
        public static void Main(string[] args)
        {
        }

        public static void SmallCalc(object o)
        {
            lock (MagicBall)
            {
                var n = (int) o;
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Hey maaaan, I got these cheeseburgers, maaan");
                }   
            }
        }
    }
}
