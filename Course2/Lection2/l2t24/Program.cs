using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2t24
{
    /*
     * Переопределите базовую операцию деления для класса Dog, так чтобы
     * при делении экземпляра Dog на 0 возвращался новый экземпляр класса Cat, а во
     * всех остальных случаях должен возвращаться число 7.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Console.WriteLine(new Dog() / 2);
            Console.WriteLine(new Dog() / 0);
        }
    }
}
