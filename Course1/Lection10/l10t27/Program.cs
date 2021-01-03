using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace l10t27
{
    /*
     * Внутри класса Program создайте и реализуйте метод Decrypt(), который будет отвечать за дешифрование строк по методу Цезаря.
     * Метод Decrypt() должен:
     *      1) Принимать в качестве входящего параметра:
     *        - строку, подлежащую дешифрованию;
     *        - целое положительное число, отвечающее за шаг сдвига;
     *        - логический параметр, отвечающий за направление сдвига (true - положительное, false - отрицательное).
     *      2) Возвращать дешифрованную строку по методу Цезаря, с учетом следующих особенностей шифрования:
     *        - сдвигу подвергались только символы русского алфавита;
     *        - пробелы, знаки препинаний и иностранные символы не изменялись.
     * Шаблон задачи изменять нельзя.
     * P.S. Не забудьте, что в русском алфавите 33 буквы, но индекс первой буквы следует начинать с нуля!
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Decrypt("Г хю шсусы!", 3, true));
            Console.WriteLine(Decrypt("А ты хорошо подумал?", 3, false));
            Console.WriteLine(Decrypt("To be, or not to be - жуч ж ьйс жуфхуц...", 5, true));
        }

        /* Добавьте свой код ниже */
        private const string alfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

        public static string Decrypt(string text, uint n, bool direction)
        {
            int k = Convert.ToInt32(n);
            if (direction) k *= -1;

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
