using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l8t18
{
    /*
     * Создайте и реализуйте публичный статический метод PrintAllByte(), который:
     *      1) Принимает экземпляр класса MemoryStream.
     *      2) Выводит в консоль каждый из байтов полученного потока с новой строки.
     *      3) Возвращает длину принятого потока.
     */

    public class Program
    {
        public static void Main(string[] args)
        {

        }

        /* Добавьте свой код ниже */
        public static long PrintAllByte(MemoryStream ms)
        {
            using (ms)
            {
                foreach (var item in ms.ToArray())
                {
                    Console.WriteLine(item);
                }

                return ms.ToArray().Length;
            }
        }
    }
}
