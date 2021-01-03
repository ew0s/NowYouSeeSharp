using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace l6t18
{
    /*
     * Внутри метода Main() получите текущий поток, присвойте ему имя Main-поток, после чего:
     * выведите в консоль информацию о нём в следующем формате "Это основной поток, его имя: ХХХ, а его
     * приоритет ХХХ", где ХХХ значения соответствующих свойств потока.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Thread.CurrentThread.Name = "Main-поток";
            Console.WriteLine($"Это основной поток, его имя: {Thread.CurrentThread.Name}, а его приоритет {Thread.CurrentThread.Priority}");
        }
    }
}
