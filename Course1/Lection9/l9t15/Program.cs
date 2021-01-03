using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l9t15
{
    /*
     * Внутри метода Main() считайте с клавиатуры текстовую строку, после чего выведите на экран две строки:
     *      1) Первая содержит только гласные буквы из введенной строки.
     *      2) Вторая содержит только согласные буквы и знаки препинания из введённой строки.
     * Символы в первой и второй строке должны быть выведены через пробел.
     * =====================================================================================================
     *      Учитывается только русский алфавит. Регистр букв имеет значение!
     *      К знакам препинания в том числе относятся следующие символы: ! ( ) ? " -
     * =====================================================================================================
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            string str = Console.ReadLine();
            char[] ch = str.ToCharArray();
            string str1 = "";
            string str2 = "";

            for (int i = 0; i < ch.Length; i++)
            {
                if ("ёуеэоаыяиюЁЕЭОАЫУЯИЮ".Contains(ch[i]))
                {
                    str1 = str1 + ch[i] + ' ';
                }
                else if ("ЙЦКНГШЩЗХЖДЛРПВФЧСМТБйцкнгшщзхждлрпвфчсмтб!()?-\",.:;".Contains(ch[i]))
                {
                    str2 = str2 + ch[i] + ' ';
                }
            }
            Console.WriteLine(str1.Substring(0, str1.Length - 1));
            Console.WriteLine(str2.Substring(0, str2.Length - 1));
        }
    }
}
