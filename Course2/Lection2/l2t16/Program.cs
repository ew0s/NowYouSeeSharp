using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2t16
{
    /*
     * Перегрузите метод Sum() образом, чтобы он стал поддерживать работу со всеми базовыми типами пар целых чисел.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Sum(uint a, uint b)
        {
            return Convert.ToInt32(a + b);
        }

        public int Sum(short a, short b)
        {
            return a + b;
        }

        public int Sum(ushort a, ushort b)
        {
            return a + b;
        }

        public int Sum(long a, long b)
        {
            return Convert.ToInt32(a + b);
        }

        public int Sum(ulong a, ulong b)
        {
            return Convert.ToInt32(a + b);
        }

        public int Sum(byte a, byte b)
        {
            return a + b;
        }

        public int Sum(sbyte a, sbyte b)
        {
            return a + b;
        }
    }
}
