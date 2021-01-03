using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l10t19
{
    /*
     * Создайте метод IsVowel(), который должен:
     *      1) Принимать символ в качестве входящего параметра.
     *      2) Возвращать true, если принятый символ гласный и относится к русскому алфавиту.
     *      3) Возвращать false во всех остальных случаях.
     * P.S. Регистр тоже учитывается!
     */

    public class Program
    {
        public static void Main(string[] args)
        {
           
        }

        /* Добавьте свой код ниже */
        public static bool IsVowel(char symbol)
        {
            return "аоуэыяёеюи".Contains(symbol.ToString().ToLower());
        }
    }
}
