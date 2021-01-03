using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l10t8
{
    /*
     * Внутри класса Program созданы 4 метода, которые необходимо последовательно
     * добавить к цепочке вызова экземпляра делегата Printer внутри метода Main()
     * и вызвать его.
     * Внутри класса Program создайте публичный делегат Printer, который бы
     * соответствовал сигнатуре 4-х не статических методов класса.
     */

    public class Program
    {
        public delegate void Printer(string p, object o, bool[] b);
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Program prog = new Program();
            Printer p = prog.PrintLine1;
            p += PrintLine2;
            p += prog.PrintLine3;
            p += PrintLine4;

            p("HELLO", "HOW ARE YOU", new []{true});
        }

        public void PrintLine1(string p, object o, bool[] b)
        {
            Console.WriteLine("O Tannenbaum, o Tannenbaum,");
        }

        public static void PrintLine2(string p, object o, bool[] b)
        {
            Console.WriteLine("Wie grün sind deine Blätter!");
        }

        public void PrintLine3(string p, object o, bool[] b)
        {
            Console.WriteLine("Du grünst nicht nur zur Sommerzeit,");
        }

        public static void PrintLine4(string p, object o, bool[] b)
        {
            Console.WriteLine("Nein auch im Winter, wenn es schneit.");
        }
    }
}
