using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace l6t4
{
    /*
     * Внутри класса Program созданы методы, каждый из которых необходимо запустить внутри метода Main() в отдельном потоке.
     * Порядок вызова методов должен соответствовать порядку их объявления. Логику работы методов изменять нельзя, а сигнатуру 
     * при необходимости можно.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Thread thread1 = new Thread(Mult1);
            Thread thread2 = new Thread(Mult2);
            Thread thread3 = new Thread(Mult3);
            Thread thread4 = new Thread(Mult4);
            Thread thread5 = new Thread(Mult5);

            thread1.Start(new Cat());
            Thread.Sleep(1000);
            thread2.Start("HELLO");
            Thread.Sleep(1000);
            thread3.Start();
            Thread.Sleep(1000);
            thread4.Start(new Dog());
            Thread.Sleep(1000);
            thread5.Start(new object());
        }

        public static void Mult1(object cat)
        {
            Console.WriteLine(cat);
        }

        public static void Mult2(object s)
        {
            Console.WriteLine(s);
        }

        public static void Mult3()
        {
            Console.WriteLine("Запускаем гуся-гидру работяги!");
        }

        public static void Mult4(object dog)
        {
            Console.WriteLine(dog);
        }

        public static void Mult5(object a)
        {
            Console.WriteLine(a);
        }
    }
}
