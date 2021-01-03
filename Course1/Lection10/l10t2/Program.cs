using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l10t2
{
    /*
     * Измените шаблон задачи таким образом, чтобы все локальные переменные метода Main() стали обладать неявно заданными типами.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            var a = 10;
            var b = 50;
            var c = 3;
            var s = "Неявная типизация это просто!";

            Console.WriteLine(s);
        }
    }
}
