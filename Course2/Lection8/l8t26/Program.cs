using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l8t26
{
    /*
     * Измените шаблон программы таким образом, чтобы каждый из не статических методов класса Program
     * стал поддерживать асинхронное выполнение, при этом поведение всех методов, возвращающих какие-либо
     * значения, должно быть изменено на вывод такого значения в консоль с новой строки.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Program p = new Program();
            p.Calc(123);
            p.Factorial();
            p.Mult(1);
            p.Printer();
        }

        public async void Printer()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Считаем: {i+1}");
            }
        }

        public async void Calc(int x)
        {
            int result = 0;
            for (int i = 0; i < x; i++)
            {
                result += i;
            }

            Console.WriteLine(result);
        }

        public async void Mult(int x)
        {
            long result = 1;
            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }

            Console.WriteLine(result);
        }

        public async void Factorial()
        {
            long result = 1;
            for (int i = 1; i <= 10; i++)
            {
                result *= i;
            }

            Console.WriteLine(result);
        }
    }
}
