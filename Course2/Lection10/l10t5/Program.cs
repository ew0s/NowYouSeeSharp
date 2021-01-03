using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l10t5
{
    /*
     * Внутри класса Program создайте публичный делегат Del, который возвращает число и
     * принимает в себя два целочисленных параметра.
     * Внутри класса Program создайте публичный метод Mult() который обладает сигнатурой созданного
     * делегата и возвращает значение первого переданного параметра в степени второго.
     * В методе Main() создайте экземпляр делегата и присвойте ему созданный метод и выведите последовательно
     * на экран степени числа 2, от -10 до 10 используя экземпляр делегата, каждый с новой строки.
     */

    public class Program
    {
        public delegate double Del(int a, int b);
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Program p = new Program();
            Del del = p.Mult;
            for (int i = -10; i <= 10; i++)
            {
                Console.WriteLine(del(2, i));
            }
        }

        public double Mult(int a, int b)
        {
            return (Math.Pow(a, b));
        }
    }
}
