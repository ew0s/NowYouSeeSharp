using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2t21
{
    /*
     * Переопределите базовый оператор сложения для экземпляров класса Cat так, чтобы в результате сложения
     * двух экземпляров класса Cat получался новый экземпляр со следующей логикой получения его полей:
     *      1) Вес - сумма значений веса обоих экземпляров.
     *      2) Возраст - сумма значений возраст обоих экземпляров.
     *      3) Имя - конкатенация значений имени второго и первого операнда.
     * Внутри метода Main() присвойте переменной cat3 значение суммы экземпляров cat1 и cat2.
     * 
     * Остальные элементы шаблона изменять нельзя.
     */

    public class CatCalculator
    {
        public static void Main(string[] args)
        {
            Cat cat1 = new Cat("Tom", 10, 10);
            Cat cat2 = new Cat("MC", 1, 7);

            Cat cat3 = cat1 + cat2;

            Console.WriteLine(cat3);
        }
    }
}
