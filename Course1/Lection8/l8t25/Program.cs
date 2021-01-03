using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l8t25
{
    /*
     * Реализуйте класс RichCat, добавив ему целочисленное автоматическое свойство Account, отвечающее за состояние счета экземпляра класса.
     * Добавьте классу RichCat конструктор, принимающий и устанавливающий значение свойства класса.
     * Создайте статический GetModNumber(), который принимает список экземпляров класса RichCat, а возвращает самое большое по модулю значение
     * свойства Account у принятых экземпляров класса.
     */

    public class RichCat
    {
        /* Добавьте свой код ниже */ 
        public int Account { get; set; }

        public RichCat(int account)
        {
            Account = account;
        }

        public static void Main(string[] args)
        {
        }
        /* Добавьте свой код ниже */
        public static int GetModNumber(List<RichCat> catList)
        {
            int richestCat = Int32.MinValue;
            int value = 0;
            foreach (RichCat cat in catList)
            {
                if (Math.Abs(cat.Account) > richestCat)
                {
                    richestCat = Math.Abs(cat.Account);
                    value = cat.Account;
                }
            }

            return value;
        }

    }
}
