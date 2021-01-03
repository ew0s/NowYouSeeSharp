using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace l10t18
{
    /*
     * Создайте метод MagicMovement(), который должен:
     *      1) Принимать строку в качестве входящего параметра.
     *      2) Если принятая строка содержит нечетное количество символов: возвращать строку которая содержит все символы принятой строки в обратном порядке.
     *      3) Если принятая строка содержит четное количество символов: возвращать строку, где четные и нечетные символы принятой строки поменяны местами.
     *      4) Если принята пустая строка: возвращать строку "Принята пустая строка".
     *      5) Если принято пустое значение: возвращать строку "Null и пустая строка не одно и тоже".
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(MagicMovement(null));
            Console.WriteLine(MagicMovement(""));
            Console.WriteLine(MagicMovement("окятат"));
        }

        /* Добавьте свой код ниже */
        public static string MagicMovement(string input)
        {
            if (input == null)
            {
                return "Null и пустая строка не одно и тоже";
            }
            if (input.Length == 0)
            {
                return "Принята пустая строка";
            }
            if (input.Length % 2 != 0)
            {
                return new string(input.ToCharArray().Reverse().ToArray());
            }
            string stringToReturn = null;
            for (int i = 1; i < input.Length; i += 2)
            {
                stringToReturn += input[i];
                stringToReturn += input[i - 1];
            }

            return stringToReturn;
        }
    }
}
