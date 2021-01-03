using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l10t7
{
    /*
     * Дополните метод Main() таким образом, чтобы в консоль всегда выводились корректные значения
     * для операций.
     * Базовый шаблон программы изменять нельзя.
     */

    public class Program
    {
        public delegate int Operation(int x, int y);

        public static void Main(string[] args)
        {
            Operation o = new Operation(Summ); // Это ссылочный тип...new чувствует себя прекрасно
            int result = o(1, 6);
            Console.WriteLine($"Сумма: {result}");
            o = Mult;
            result = o(1, 6);
            Console.WriteLine($"Произведение: {result}");
        }

        public static int Summ(int x, int y)
        {
            return x + y;
        }

        public static int Mult(int x, int y)
        {
            return x * y;
        }
    }
}
