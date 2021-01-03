using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2t22
{
    /*
     * Переопределите базовый оператор вычитания для экземпляров класса Cat так, чтобы в результате вычитания
     * двух экземпляров класса Cat получался новый экземпляр со следующей логикой получения его полей:
     *      1) Вес - разность весов объектов взятая по модулю.
     *      2) Возраст - разность значений возраста обоих экземпляров, взятая по модулю.
     *      3) Имя - имя одного из операндов, длина которого является наибольшей. Если длинна имён одинаковая,
     *         то новому экземпляру должно присваиваться имя первого операнда.
     * Внутри метода Main() присвойте переменной cat3 значение разности экземпляров cat1 и cat2.
     * 
     * Остальные элементы шаблона изменять нельзя.
     */

    public class CatCalculator
    {
        public static void Main(string[] args)
        {
            Cat cat1 = new Cat("Timmy", 10, 10);
            Cat cat2 = new Cat("Ronald", 11, 15);

            Cat cat3 = cat1 - cat2;

            Console.WriteLine(cat3);
        }
    }

    public class Cat
    {
        private string name;
        private int age;
        private int weight;

        public Cat(string name, int age, int weight)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
        }

        public static Cat operator -(Cat lValueCat, Cat rValueCat)
        {
            string name = lValueCat.name.Length == rValueCat.name.Length ? lValueCat.name
                : rValueCat.name.Length > lValueCat.name.Length ? rValueCat.name : lValueCat.name;
            return new Cat(name, Math.Abs(lValueCat.age - rValueCat.age), Math.Abs(lValueCat.weight - rValueCat.weight));
        }

        public override string ToString()
        {
            return $"Ты чего наделал??? Теперь меня зовут {name}, мой возраст {age} и вешу я аж {weight}";
        }
    }
}
