using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2t14
{
    /*
     * Перегрузите метод Printer() таким образом, чтобы он стал поддерживать работу с символами.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
        }

        public void Printer(string s)
        {
            Console.WriteLine(s);
        }

        public void Printer(char c)
        {
            Console.WriteLine(c);
        }
    }
}
