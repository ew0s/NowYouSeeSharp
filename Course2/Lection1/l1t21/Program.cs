using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l1t21
{
    /*
     * Внутри программы имеется 2 класса: Bird и Duck, между которыми установлены наследственные связи.
     * Сейчас все поля и свойства классов являются открытыми, что не очень хорошо согласуется с принципом инкапсуляции.
     * Необходимо изменить модификаторы доступа для каждого из полей и свойств классов, сделав их максимально закрытыми 
     * в условиях текущего кода программы. Программа при этом должна компилироваться.
     * 
     * Остальные элементы классов изменять нельзя. 
     */

    public class Zoo
    {
        public static void Main(string[] args)
        {
            Duck duck1 = new Duck("Дейзи", false);
            Duck duck2 = new Duck("Дональд", false);
            FeedDuck(duck1, 120);
            FeedDuck(duck2, 90);
            FeedDuck(duck1, 101);
            Console.WriteLine(duck1.Name);
            Console.WriteLine(duck2.currentLake);
            Console.WriteLine(Bird.TotalCount);
        }

        public static void FeedDuck(Duck duck, int bread)
        {
            duck.Eat(bread);
        }
    }
}
