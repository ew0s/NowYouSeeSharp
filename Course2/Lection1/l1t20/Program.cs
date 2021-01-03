using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l1t20
{
    /*
     * Внутри класса WildNature смоделирована ситуация с кормлением уточек в пруду. 
     * Сейчас программа при запуске выводит не вполне корректные сведения в консоль.
     * Найдите в чем кроется проблема и внесите соответствующие изменения, чтобы вывод
     * стал корректным.
     * 
     * При этом внутри программы нельзя: 
     *      1) Изменять код в классе WildNature.
     *      2) Добавлять\удалять переменные и свойства классов Duck и Bird. 
     */

    public class WildNature
    {
        public static void Main(string[] args)
        {
            Duck duck1 = new Duck("Дейзи", false);
            Duck duck2 = new Duck("Дональд", false);
            FeedDuck(duck1, 120);
            FeedDuck(duck2, 90);
            FeedDuck(duck1, 101);
            Console.WriteLine(duck1.AllLittleDuckCount);
            Console.WriteLine(duck2.currentLake);
            Console.WriteLine(Bird.TotalCount);
            Console.WriteLine(duck2.Weight);
            duck2
        }

        public static void FeedDuck(Duck duck, int bread)
        {
            duck.Eat(bread);
        }       
    }
}
