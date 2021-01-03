using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace l7t17
{
    /*
     * Внутри метода Main() созданы и запущены 2 потока. Каждый из них в результате работы должен вывести в консоль
     * результат простейшей математической операции. В текущем варианте, потоки не особо синхронизированы и не слишком
     * приближаются к выполнению поставленной задачи. Проанализируйте шаблон, дополните его таким образом, чтобы:
     *      1) Каждый из методов в программе, зависящий от результата работы других методов, инициализировал запуск
     *         таких методов в отдельном потоке.
     *      2) Каждый дочерних потоков метода Main() стал выводить в консоль корректные значения.
     * Базовый шаблон метода Main() изменять нельзя.
     */

    public class Program
    {
        public static int s;
        public static int e;
        public static int h;
        public static int r;
        public static int g;
        public static int u;
        public static int t;

        public static void Main(string[] args)
        {
            Thread t1 = new Thread(WhySoSerious);
            Thread t2 = new Thread(RaceNumberCalc);
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
        }

        public static void RaceNumberCalc()
        {
            Thread thr1 = new Thread(S);
            thr1.Start();
            thr1.Join();
            Thread thr2 = new Thread(E);
            thr2.Start();
            thr2.Join();
            Thread thr3 = new Thread(H);
            thr3.Start();
            thr3.Join();
            Thread thr4 = new Thread(R);
            thr4.Start();
            thr4.Join();
            Console.WriteLine(s + e + h + r);

        }

        public static void S()
        {
            Thread.Sleep(100);
            s = 100;
        }

        public static void E()
        {
            Thread.Sleep(100);
            e = 7;
        }

        public static void H()
        {
            Thread.Sleep(30);
            h = 101230;
        }

        public static void R()
        {
            Thread.Sleep(123);
            h = 123;
        }

        public static void G()
        {
            Thread thr20 = new Thread(S);
            thr20.Start();
            thr20.Join();
            Thread thr21 = new Thread(E);
            thr21.Start();
            thr21.Join();
            Thread.Sleep(333);
            g = s + e - 10;
        }

        public static void U()
        {
            Thread thr30 = new Thread(S);
            thr30.Start();
            thr30.Join();
            Thread thr31 = new Thread(G);
            thr31.Start();
            thr31.Join();
            u = g * s;
        }

        public static void T()
        {
            Thread thr40 = new Thread(S);
            thr40.Start();
            thr40.Join();
            Thread thr41 = new Thread(E);
            thr41.Start();
            thr41.Join();
            Thread thr42 = new Thread(H);
            thr42.Start();
            thr42.Join();
            Thread thr43 = new Thread(R);
            thr43.Start();
            thr43.Join();
            Thread thr44 = new Thread(G);
            thr44.Start();
            thr44.Join();
            Thread thr45 = new Thread(U);
            thr45.Start();
            thr45.Join();
            t = s + e + h + r - g * u;
        }

        public static void WhySoSerious()
        {
            Thread thr10 = new Thread(S);
            thr10.Start();
            thr10.Join();
            Thread thr11 = new Thread(E);
            thr11.Start();
            thr11.Join();
            Thread thr12 = new Thread(H);
            thr12.Start();
            thr12.Join();
            Thread thr13 = new Thread(R);
            thr13.Start();
            thr13.Join();
            Thread thr14 = new Thread(G);
            thr14.Start();
            thr14.Join();
            Thread thr15 = new Thread(U);
            thr15.Start();
            thr15.Join();
            Thread thr16 = new Thread(T);
            thr16.Start();
            thr16.Join();
            Console.WriteLine(s + e + h + r + g + u + t);
        }
    }


}
