using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l8t1
{
    /*
     * Внутри метода Main() создайте экземпляр класса FileStream, после чего последовательно выведите
     * в консоль информацию о следующих свойствах полученного потока:
     *      1) Может ли поток осуществлять операции записи.
     *      2) Может ли поток осуществлять операции чтения.
     *      3) Может ли поток осуществлять асинхронные операции.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            FileStream fs = new FileStream("s", FileMode.OpenOrCreate);
            Console.WriteLine(fs.CanWrite);
            Console.WriteLine(fs.CanRead);
            Console.WriteLine(fs.IsAsync);
        }
    }
}
