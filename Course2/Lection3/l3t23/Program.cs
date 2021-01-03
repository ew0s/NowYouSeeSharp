using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3t23
{
    /*
     * Добавьте явную реализацию интерфейса ISum для класса Program.
     * 
     * Интерфейс ISum изменять нельзя.
     */

    public class Program : ISum
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
        }
        
        long ISum.Sum(int a, int b)
        {
            return a + b;
        }

        int ISum.Sum(short a, short b)
        {
            return a + b;
        }
        short ISum.Sum(byte a, byte b)
        {
            return (short) (a + b);
        }

        float ISum.Sum(double a, double b)
        {
            return (float) (a + b);
        }

        float ISum.Sum(int a, double b)
        {
            return (float) (a + b);
        }
    }
}
