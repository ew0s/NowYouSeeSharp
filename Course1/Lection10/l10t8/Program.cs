using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l10t8
{
    /*
     * Проанализируйте шаблон и внесите изменения так, чтобы в консоль был выведен корректный результат сложения.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            short a = 100;
            int b = 3647;
            long c = 2147480000;
            byte d = 12;

            long result = a + b + c + d;

            Console.WriteLine(result);
        }
    }
}
