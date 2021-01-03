using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l10t20
{
    /*
     * Реализуйте метод MagicReverse(), который:
     *      1) Должен возвращать принятую строку, записанную в обратном порядке, если строка заканчивается гласной буквой.
     *      2) Должен возвращать принятую строку, записанную символами с обратными регистром, если строка заканчивается согласной буквой.
     *      3) Если строка не заканчивается буквой, то она должна быть возвращена без изменения.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(MagicReverse("Красота"));
            Console.WriteLine(MagicReverse("КоТ"));
            Console.WriteLine(MagicReverse("Победа!"));
            Console.WriteLine(MagicReverse("ЗаМоК"));
            Console.WriteLine(MagicReverse("Яизенма"));
        }

        public static string MagicReverse(string s)
        {
            /* Добавьте свой код ниже */
            string glasny = "аоуэыяёеюи";

            if (char.IsLetter(s[s.Length - 1]))
            {
                if (glasny.Contains(s[s.Length - 1]))
                {
                    return new string(s.ToCharArray().Reverse().ToArray());
                }
                string output = null;
                foreach (char c in s)
                {
                    output += char.IsLower(c) ? char.ToUpper(c) : char.ToLower(c);
                }

                return output;
            }

            return s;
        }
    }
}
