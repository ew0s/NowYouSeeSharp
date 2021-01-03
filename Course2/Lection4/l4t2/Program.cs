using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l4t2
{
    /*
     * Пометьте все элементы класса Program атрибутом Magic.
     */

    [Magic]
    public class Program
    {
        [Magic]
        public string count;
        [Magic]
        public static int Name { get; set; }

        [Magic]
        public static void Main(string[] args)
        {
            new Program().Write("Лакшери атрибуты");
        }

        [Magic]
        public void Write(string s)
        {
            Console.WriteLine(s);
        }
    }
}
