using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5t8
{
    /*
     * Измените программу и реализуйте метод PrintName чтобы он выполнялся и для классов Car и SuperCar, выводя в консоль имена 
     * принятых экземпляров класса. 
     * Сигнатуру метода PrintName и шаблон метода Main() изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            Car car = new Car();
            SuperCar sCar = new SuperCar();

            PrintName(car);
            PrintName(sCar as Car);
        }

        public static void PrintName(Car car)
        {
            Console.WriteLine(car.name);
        }
    }
}
