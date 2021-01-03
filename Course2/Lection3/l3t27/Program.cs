using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3t27
{
    /*
     * Реализуйте метод IsACat() так, чтобы в результате его работы он возвращал логическое значение,
     * характеризующее принадлежность принятого экземпляра класса к классу Cat.
     */

    public class Cat
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(IsACat(new Cat()));
            Console.WriteLine(IsACat(5));
            Console.WriteLine(IsACat("кот"));
            Console.WriteLine(IsACat('K'));
            Console.WriteLine(IsACat(777f));
        }

        public static bool IsACat(object o)
        {
            /* Добавьте свой код ниже */
            return o is Cat;
        }
    }
}
