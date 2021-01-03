using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l10t5
{
    /*
     * Проанализируйте шаблон и измените его таким образом, чтобы:
     *      1) Все неявно заданные типы переменных задавались явно.
     *      2) Метод GetAllEvenChars стал обладать обратной логикой включения символов в возвращаемую строку.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(GetAllEvenChars("ААВВООТТИИДНАЕ Т"));
        }

        public static string GetAllEvenChars(string s)
        {
            string temp = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 != 0)
                {
                    temp += s.ToCharArray()[i];
                }
            }
            return temp;
        }
    }
}
