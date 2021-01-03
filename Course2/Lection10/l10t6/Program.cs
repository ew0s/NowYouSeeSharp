using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l10t6
{
    /*
     * Внутри класса Program создано 3 делегата. Создайте по 2 произвольных статических
     * метода для каждого из делегатов. Внутри метода Main() создайте по 2 экземпляра 
     * каждого из делегатов с разными методами при их вызове.
     */

    public class Program
    {
        public delegate void Operation1(int a, int b, string s);
        public delegate string Operation2(string[] s, int a, Program p);
        public delegate bool Operation3(bool b, bool d);

        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Operation1 operation1_1 = oper1_1;
            Operation1 operation1_2 = oper1_2;
            Operation2 operation2_1 = oper2_1;
            Operation2 operation2_2 = oper2_2;
            Operation3 operation3_1 = oper3_1;
            Operation3 operation3_2 = oper3_2;
        }

        public static void oper1_1(int a, int b, string s)
        {

        }

        public static void oper1_2(int a, int b, string s)
        {

        }

        public static string oper2_1(string[] s, int a, Program p)
        {
            return "";
        }

        public static string oper2_2(string[] s, int a, Program p)
        {
            return "";
        }

        public static bool oper3_1(bool b, bool d)
        {
            return true;
        }

        public static bool oper3_2(bool b, bool d)
        {
            return true;
        }
    }
}
