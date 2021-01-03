using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace l6t20
{
    /*
     * Создайте публичный класс с произвольным именем в том же namespace что и класс Program,
     * который должен содержать 3 публичных целочисленных поля с произвольными именами.
     * Внутри класса Program создайте публичный статический метод TripleReader(), который:
     *      1) Будет запускаться в отдельном потоке.
     *      2) Принимает экземпляр созданного вами класса.
     *      3) Устанавливает значение полей принятого экземпляра класса,  присвоив ему считанные с клавиатуры числа.
     * Внутри класса Program создайте публичный статический метод SumPrinter(), который:
     *      1) Будет запускаться в отдельном потоке.
     *      2) Принимает экземпляр созданного вами класса.
     *      3) Выводит в консоль сумму значений полей полученного экземпляра класса.
     * Внутри метода Main() создайте новый экземпляр вашего класса, после чего:
     *      1) Создайте 1 экземпляр созданного вами класса.
     *      2) Создайте и запустите два потока: t1 для метода SumPrinter(), а t2 для метода TripleReader().
     *      3) Сделайте так, чтобы поток t1 отрабатывал только после того, как завершиться выполнение потока t2.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            TmpClass tmpClass = new TmpClass();
            Thread t1 = new Thread(SumPrinter);
            Thread t2 = new Thread(TripleReader);

            t2.Start(tmpClass);
            t2.Join();
            t1.Start(tmpClass);
        }

        public static void TripleReader(object tmpClass)
        {
            (tmpClass as TmpClass).r1 = Convert.ToInt32(Console.ReadLine());
            (tmpClass as TmpClass).r2 = Convert.ToInt32(Console.ReadLine());
            (tmpClass as TmpClass).r3 = Convert.ToInt32(Console.ReadLine());
        }

        public static void SumPrinter(object tmpClass)
        {
            Console.WriteLine((tmpClass as TmpClass).r1 + (tmpClass as TmpClass).r2 + (tmpClass as TmpClass).r3);
        }
    }

    public class TmpClass
    {
        public int r1;
        public int r2;
        public int r3;
    }
}
