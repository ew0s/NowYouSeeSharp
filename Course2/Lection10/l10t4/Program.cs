using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace l10t4
{
    /*
     * Внутри метода Main() создайте 1 экземпляр делегата Message, после чего
     * выведите в консоль два раза результат вызова экземпляра, передав ему 
     * при первом запуске строку "Быть программистом - хорошо!", а при втором
     * запуске строку "А хорошим программистом - ещё лучше!".
     * При этом первая строка должна быть выведена в консоль в верхнем регистре, а 
     * вторая в нижнем.
     */

    public class Program
    {
        public delegate string Message(string s, bool inUpperCase);

        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Message message = Line;
            Console.WriteLine(message("Быть программистом - хорошо!", true));
            Console.WriteLine(message("А хорошим программистом - ещё лучше!", false));
        }

        public static string Line(string s, bool b)
        {
            return b ? s.ToUpper() : s.ToLower();
        }
    }
}
