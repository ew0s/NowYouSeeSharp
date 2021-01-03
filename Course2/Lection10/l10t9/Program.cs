using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l10t9
{
    /*
     * Внутри метода Main() выведите в консоль имена всех методов, которые находятся
     * внутри цепочки вызова созданного делегата, каждого с новой строки.
     */

    public class Program
    {
        public delegate void Scarface();
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Scarface s = Say;
            s += new Program().Hello;
            s += To;
            s += My;
            s += new Program().Little;
            s += Friend;
        }

        public static void Say() { }
        public void Hello() { }
        public static void To() { }
        public static void My() { }
        public void Little() { }
        public static void Friend() { }
    }
}
