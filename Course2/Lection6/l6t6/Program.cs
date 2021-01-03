using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace l6t6
{
    /*
     * Внутри метода Main() создайте новый поток, который должен запускать метод Mult(). Прежде чем запустить
     * новый поток - измените его имя на "МойЛюбимыйПоток!", после чего запустите его.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Thread thread = new Thread(Mult);
            thread.Name = "МойЛюбимыйПоток!";
            thread.Start();
        }

        public static void Mult()
        {
            Console.WriteLine(10101 * 110101);
        }
    }
}
