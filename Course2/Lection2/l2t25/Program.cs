using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2t25
{
    /*
     * Зададим свою собственную логику оператору для класса Cat! Пусть операция будет унарной.
     * Перегрузите любой подходящий оператор так, чтобы результат работы данной операции увеличивал
     * все целочисленные значения полей экземпляра в 2 раза, если это не превышает максимальную 
     * вместимость типа переменой.
     * Если в результате операции значение будет превышать максимальную вместимость - переменная не
     * должна изменять своё значение.
     */

    public class Cat
    {
        public string name;
        public int age;
        public short speed;
        public double weight;

        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Cat cat = new Cat();
            cat.age = Int32.MaxValue;
            cat.speed = Int16.MaxValue;

            cat++;

            Console.WriteLine(cat.age);
            Console.WriteLine(cat.speed);
        }

        public static Cat operator ++(Cat cat)
        {
            try
            {
                checked
                {
                    cat.age *= 2;
                }
            }
            catch (Exception)
            {
                //ignored
            }

            try
            {
                checked
                {
                    cat.speed *= 2;
                }
            }
            catch (Exception)
            {
                // ignored
            }

            return cat;
        }
    }
}
