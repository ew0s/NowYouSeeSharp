using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace l10t21
{
    /*
     * Внутри класса Program создайте и реализуйте метод Encrypt(), который будет отвечать за шифрование строк по методу Цезаря.
     * Метод Encrypt() должен:
     *      1) Принимать в качестве входящего параметра:
     *        - строку, подлежащую шифрованию;
     *        - целое положительное число, отвечающее за шаг сдвига;
     *        - логический параметр, отвечающий за направление сдвига (true - положительное, false - отрицательное).
     *      2) Возвращать шифрованную строку по методу Цезаря, с учетом следующих особенностей шифрования:
     *        - сдвигу подвергаются только символы русского алфавита;
     *        - пробелы, знаки препинаний и иностранные символы не должны изменяться.
     * Шаблон задачи изменять нельзя.
     * P.S. Не забудьте, что в русском алфавите 33 буквы, но индекс первой буквы следует начинать с нуля!
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Encrypt("Дружище!!!", 3, true));
            Console.WriteLine(Encrypt("Как мне кажется, первый курс и основы синтаксиса .Net тобой изучены отлично!", 6, false));
            Console.WriteLine(Encrypt("Осталось чуть-чуть и ты будешь на шаг ближе к своей мечте!", 3, true));
        }

        /* Добавьте свой код ниже */
        private const string alfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

        public static string Encrypt(string text, uint n, bool direction)
        {
            int k = Convert.ToInt32(n);
            if (!direction) k *= -1;

            var lowAlphabet = alfabet.ToLower();
            var retVal = "";

            for (int i = 0; i < text.Length; i++)
            {
                var c = text[i];
                if (Char.IsLower(c))
                {
                    var index = lowAlphabet.IndexOf(c);
                    if (index < 0)
                    {
                        retVal += c.ToString();
                    }
                    else
                    {
                        var codeIndex = (lowAlphabet.Length + index + k) % lowAlphabet.Length;
                        retVal += lowAlphabet[codeIndex];
                    }
                }
                else
                {
                    var index = alfabet.IndexOf(c);
                    if (index < 0)
                    {
                        retVal += c.ToString();
                    }
                    else
                    {
                        var codeIndex = (alfabet.Length + index + k) % alfabet.Length;
                        retVal += alfabet[codeIndex];
                    }
                }
            }

            return retVal;
        }
    }
}
