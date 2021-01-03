using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace l7t14
{
    /*
     * Проанализируйте код программы, внесите изменения так, чтобы избежать возникновения взаимной блокировки потоков.
     * Шаблон метода Main(), а также логику работы остальных методов, изменять нельзя.
     */

    // Как это делать ?

    public class Program
    {
        static object o1 = new object();
        static object o2 = new object();

        public static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(HardLock));
            Thread t2 = new Thread(new ThreadStart(SoftLock));
            t1.Start();
            t2.Start();
        }

        public static void HardLock()
        {
            lock (o1)
            {
                Console.WriteLine("Thread 1 got locked");
                Thread.Sleep(500);
                Console.WriteLine("Thread 2 got locked");
            }
        }

        public static void SoftLock()
        {
            lock (o2)
            {
                Console.WriteLine("Thread 2 got locked");
                Thread.Sleep(500);
                Console.WriteLine("Thread 1 got locked");
            }
        }
    }
}
