using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l8t24
{
    /*
     * Клиенты банка PrivateCatBank столкнулись со странным ограничением на совершение операций со своими счетами.
     * Они могут снимать со счета 300 монеток и пополнять свой счет на 198 монеток.
     * Внутри метода Main() реализуйте логику работы программы, которая поможет определить какую максимальную сумму
     * сможет снять клиент данного банка, если его текущий баланс - 500 монеток. Выведите на экран получившееся значение.
     */

    public class PrivateCatBank
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            long moneyOnAccount = 500;
            while ((moneyOnAccount % 300) != 2) //2 получил перебором
            {
                moneyOnAccount += 198;
            }
            while (moneyOnAccount > 0)
            {
                moneyOnAccount -= 300;
            }
            moneyOnAccount += 300;
            Console.WriteLine(500 - moneyOnAccount);
        }
    }
}
