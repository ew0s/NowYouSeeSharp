using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace l6t19
{
    /*
     * Внутри метода Main() создайте такое количество потоков, чтобы каждый из них имел уникальное
     * значение своего приоритета. После чего для класса Program создайте публичный типизированный список 
     * threads, в который добавьте все созданные потоки в порядке убывания их приоритета.
     */

    public class Program
    {
        public static List<Thread> threads = new List<Thread>();
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Thread thread1 = new Thread(tmp);
            Thread thread2 = new Thread(tmp);
            Thread thread3 = new Thread(tmp);
            Thread thread4 = new Thread(tmp);
            Thread thread5 = new Thread(tmp);

            thread1.Priority = ThreadPriority.Highest;
            thread2.Priority = ThreadPriority.AboveNormal;
            thread3.Priority = ThreadPriority.Normal;
            thread4.Priority = ThreadPriority.BelowNormal;
            thread5.Priority = ThreadPriority.Lowest;

            threads.Add(thread1);
            threads.Add(thread2);
            threads.Add(thread3);
            threads.Add(thread4);
            threads.Add(thread5);
        }

        public static void tmp()
        {

        }
    }
}
