using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace l2t23
{
    /*
     * Переопределите оператора сложения для класса Cat так, чтобы в результате
     * операции возвращалась строка "Да, можно и вот так".
     */

    public class Cat
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Console.WriteLine(new Cat() + new Cat());
        }

        public static string operator +(Cat lValueCat, Cat rValueCat)
        {
            return "Да, можно и вот так";
        }
    }
}
