using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2t28
{
    /*
     * Реализуйте механизм явного преобразования экземпляров класса Hedgehog к классу Snake, с учетом следующей логики:
     *      1) Длина получившегося экземпляра совпадает с исходным.
     *      2) Максимальная длина получившегося экземпляра не должна превышать 3.
     *      3) Максимальный вес получившегося экземпляра не должен превышать 5.
     *      4) В случае получения нулевых или отрицательных значений от исходного объекта,
     *         должен получаться объект с максимально допустимыми значениями по условию задачи.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Hedgehog hedgehog = new Hedgehog() {Lenght = -10, Weight = -10};
            Snake snake = (Snake) hedgehog;

            Console.WriteLine(snake.Lenght);
            Console.WriteLine(snake.Weight);
        }
    }
}
