using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2t6
{
    /*
     * Создайте 2 класса: Cat и Cow. Внутри класса Cat создайте метод Say(), который бы выводил на экран фразу:
     *      "Я - кот!". 
     * Внутри класса Cow переопределите метод Say так, чтобы он выводил в консоль фразу:
     *      "Я - корова, но внутри я тоже котик!".
     * Внутри метода Main() создайте по 1 экземпляру классов и вызовите у них метод Say().
     * 
     * P.S. Все классы должны быть созданы в отдельном файле!
     */

    public class StrangeWorld
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Cat cat = new Cat();
            Cow cow = new Cow();

            cow.Say();
            cat.Say();
        }
    }
}
