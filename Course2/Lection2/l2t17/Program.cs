using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2t17
{
    /*
     * Перегрузите статический метод ToCat() таким образом, чтобы:
     *      1) Он принимал строку в качестве входящего параметра.
     *      2) Возвращал новый экземпляр класса Cat и устанавливал ему следующие значения свойств:
     *          1) Age - длинна полученной строки.
     *          2) Weight - количество заглавных букв в строке.
     * Внутри метода Main() выведите в консоль результаты работы двух перегрузок метода ToCat() в
     * произвольном порядке.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(ToCat("BOBA").ToString());
            Console.WriteLine(ToCat());
        }

        /* Добавьте свой код ниже */

        public static string ToCat()
        {
            return "Воздушный котик!";
        }

        public static Cat ToCat(string cat)
        {
            int count = 0;
            foreach (var symbol in cat)
            {
                if (char.IsUpper(symbol)) count++;
            }
            return new Cat(cat.Length, count);
        }
    }
}
