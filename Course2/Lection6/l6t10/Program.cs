using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace l6t10
{
    /*
     * Внутри метода Main() класса Program создайте последовательно 5 потоков:
     *      1) Первый поток должен выводить в консоль фразу "Одна работа, никакого безделья...".
     *      2) Второй поток должен выводить в консоль фразу "Бедняга Джек не знает веселья...".
     *      3) Третий поток должен считывать с клавиатуры строки до тех пор, пока не считается 20
     *         строк, после чего выводить в консоль сумму всех встретившихся чисел в строках.
     *      4) Четвертый поток должен выводить в консоль значение всех простых степеней цифры 2 в 
     *         диапазоне от 0 до 20, каждое с новой строки.
     *      5) Пятый поток должен выбрасывать исключение, указывающее на отсутствие реализации в его методе.
     * Для каждого из созданных потоков создайте публичные статические методы, отвечающие за реализацию их
     * функционала и именуемые по принципу "MethodXXX", где ХХХ - порядковый номер потока, функционал которого
     * они реализуют.
     * Поместите в публичную статическую коллекцию экземпляров класса Thread allMyThreads все созданные внутри метода
     * Main() потоки в той очередности, в которой требуется их создание. При этом каждый их потоков должен обладать именем,
     * отличного от значения по умолчанию. Запускать созданные в методе Main() потоки не требуется.
     */

    public class Program
    {
        public static List<Thread> allMyThreads = new List<Thread>();
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Thread thread1 = new Thread(Method1);
            Thread thread2 = new Thread(Method2);
            Thread thread3 = new Thread(Method3);
            Thread thread4 = new Thread(Method4);
            Thread thread5 = new Thread(Method5);

            thread1.Name = "1";
            thread2.Name = "2";
            thread3.Name = "3";
            thread4.Name = "4";
            thread5.Name = "5";

            allMyThreads.Add(thread1);
            allMyThreads.Add(thread2);
            allMyThreads.Add(thread3);
            allMyThreads.Add(thread4);
            allMyThreads.Add(thread5);

            thread3.Start();
        }

        public static void Method1()
        {
            Console.WriteLine("Одна работа, никакого безделья...");
        }

        public static void Method2()
        {
            Console.WriteLine("Бедняга Джек не знает веселья...");
        }

        public static void Method3()
        { 
            var totalNumber = 0;

            for (int i = 0; i < 20; i++)
            {
                var str = Console.ReadLine();
                if (string.IsNullOrEmpty(str)) continue;

                if (Int32.TryParse(str, out var value))
                {
                    totalNumber += value;
                }
            }

            Console.WriteLine(totalNumber);
        }

        public static void Method4()
        {
            int[] simpleNumbers = {2, 3, 5, 7, 11, 13, 17, 19};
            foreach (var number in simpleNumbers)
            {
                Console.WriteLine(Math.Pow(2, number));
            }
        }

        public static void Method5()
        {
            throw new NotImplementedException();
        }
    }
}
