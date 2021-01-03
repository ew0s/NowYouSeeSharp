using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5t10
{
    /*
     * Внутри класса RandomString создайте и реализуйте метод GetRandomString(), который:
     *      1) Принимает строку в качестве входящего параметра.
     *      2) Возвращает случайную строку, составленную из символов входящей строки.
     *      3) Длина возвращаемой строки должна совпадать с длиной принятой.
     *      4) Символы в разных регистрах считаются различными символами.
     *      5) Каждый раз при вызове этого метода – строка должна быть разной, а случае если
     *         длина принятой строки не позволяет сформировать новую уникальную строку (все варианты исчерпаны),
     *         то длина возвращаемой строки должна увеличиваться в два раза.
     *      6) Возвращает null, если полученная строка пустая или null.
     */

    public class RandomString
    {
        public static Dictionary<string, List<string>> StringsPermutations = new Dictionary<string, List<string>>();
        public HashSet<string> AllStrings = new HashSet<string>();
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
        }

        public static string GetRandomString(string input)
        {
            var newString = MakeString(input);

            if (StringsPermutations.ContainsKey(input))
            {

            }
            else
        }

        private static string MakeString(string input)
        {
            var charList = new List<char>(input);
            var rnd = new Random();

            foreach (var c in input)
            {
                if (!charList.Contains(c))
                {
                    charList.Add(c);
                }
            }

            string outString = null;

            for (int i = 0; i < input.Length; i++)
            {
                outString += charList[rnd.Next(0, charList.Count)];
            }

            return outString;
        }
    }

}
