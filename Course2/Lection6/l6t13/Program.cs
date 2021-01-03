using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace l6t13
{
    /*
     * Создайте метод Start(), который будет выполняться в отдельном потоке и выводить на экран надпись "Марш!!!". 
     * Создайте метод GetSet(), который будет выполняться в отдельном потоке и выполнять функции таймера с обратным отсчетом
     * от 10 до 0, без вывода информации в консоль. Время обратного отсчета должно совпадать с реальным временем, 
     * т.е. программа должна работать не менее 10 секунд реального времени прежде чем отсчет дойдет до 0. 
     * Внутри метода Main():
     *      1) Создайте два отдельных потока для запуска методов Start() и GetSet().
     *      2) Выведите в консоль фразу "На старт...", после чего запустите нить отвечающую за обратный отсчёт.
     *      3) Когда таймер дойдет до 5 выведите на экран "Внимание...".
     *      4) Когда таймер дойдет до конца запустите поток, который выведет на экран фраза "Марш!!!".
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Thread thread1 = new Thread(Start);
            Thread thread2 = new Thread(GetSet);

            Console.WriteLine("На старт...");
            thread2.Start();
            thread2.Join();
            thread1.Start();
        }

        public static void Start()
        {
            Console.WriteLine("Марш!!!");
        }

        public static void GetSet()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine("Внимание...");
                }
                Thread.Sleep(1000);
            }
        }
    }
}
