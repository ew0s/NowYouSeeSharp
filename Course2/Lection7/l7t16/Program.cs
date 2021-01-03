using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace l7t16
{
    /*
     * Внутри класса Program создайте публичный статический метод SmartCounter(), который должен
     * выводить в консоль числа от x до 10 в следующем формате: "XXX: YYY", где ХХХ - имя потока,
     * а YYY - числа, выводимые в методе.
     * Внутри класса Program создайте публичную статическую целочисленную переменную x, которая
     * будет отвечать за начальное значение чисел в методе SmartCounter().
     * Внутри метода Main() запустите метод SmartCounter() 5 раз, каждый в новом потоке, присвоив
     * перед запуском каждому из потоков своё уникальное имя в формате: "Новый поток ZZZ", где
     * ZZZ - порядковый номер создаваемого потока, начиная с 1.
     * Каждый из запущенных методов должен отработать корректно в своём потоке, при этом оператор lock
     * использовать запрещено.
     */

    public class Program
    {
        public static int x = 1; 
        public static object locker = new object();
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            for (int i = 1; i <= 5; i++)
            {
                var thread = new Thread(SmartCounter);
                thread.Name = $"Новый поток {i}";
                thread.Start();
            }
        }

        public static void SmartCounter()
        {
            bool trigger = false;

            try
            {
                Monitor.Enter(locker, ref trigger);
                for (int i = x; i <= 10; i++)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name}: {i}");
                }
            }
            finally
            {
                if (trigger)
                {
                    Monitor.Exit(locker);
                }
            }
        }
    }
}
