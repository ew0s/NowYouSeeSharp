using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace l6t5
{
    /*
     * Внутри метода Main() задан шаблон для запуска методов в отдельном потоке. Создайте внутри класса
     * Program недостающие статические методы так, чтобы программа скомпилировалась. Каждый из методов 
     * должен просто выводить в консоль те элементы, что были переданы ему в качестве входящего параметра.
     * В случае если метод ничего не принимает, то в консоль должна быть выведена фраза "Вот так вот (с)".
     * Базовый шаблон программы не должен быть изменён.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            (double, string) s1 = (11d, "Если что, это кортеж");
            (string, string) s2 = ("Это такой тип данных", "По сути это просто упорядоченный набор фиксированной длины");
            Thread t1 = new Thread(PrintElement1);
            Thread t2 = new Thread(PrintElement1);
            Thread t3 = new Thread(PrintElement1);
            Thread t4 = new Thread(PrintElement1);
            Thread t5 = new Thread(PrintElement2);
            Thread t6 = new Thread(PrintElement1);
            Thread t7 = new Thread(PrintElement1);
            t1.Start(new Cat("Том"));
            t2.Start(new Dog(777));
            t3.Start("Мишка и шишка");
            t4.Start(123);
            t5.Start();
            t6.Start(s1);
            t7.Start(s2);
        }
        /* Добавьте свой код ниже */
        public static void PrintElement1(object obj)
        {
            Console.WriteLine(obj);
        }

        public static void PrintElement2()
        {
            Console.WriteLine("Вот так вот (с)");
        }
    }
}
