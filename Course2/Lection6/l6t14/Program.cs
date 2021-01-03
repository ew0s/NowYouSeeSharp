using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace l6t14
{
    /*
     * Реализуйте класс Horse, внутри которого создайте целочисленное поле id с соответствующим конструктором класса. 
     * Определите в классе Horse метод Run(), который с интервалом в 1 секунду выводит числа от 5 до 0, после чего 
     * выводит на экран надпись: "Лошадка с номером XXX финишировала", где ХХХ значение поля id текущего экземпляра класса, 
     * полученного в качестве входящего параметра. 
     * Внутри метода Main() создайте 10 лошадок в отдельных потоках и запустите их.
     * Использовать метод расширения ForEach() нельзя.
     */

    public class Horse
    {
        public int id;

        public Horse(int id)
        {
            this.id = id;
        }

        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Thread thread1 = new Thread(Run);
            Thread thread2 = new Thread(Run);
            Thread thread3 = new Thread(Run);
            Thread thread4 = new Thread(Run);
            Thread thread5 = new Thread(Run);
            Thread thread6 = new Thread(Run);
            Thread thread7 = new Thread(Run);
            Thread thread8 = new Thread(Run);
            Thread thread9 = new Thread(Run);
            Thread thread10 = new Thread(Run);

            thread1.Start(new Horse(1));
            thread2.Start(new Horse(2));
            thread3.Start(new Horse(3));
            thread4.Start(new Horse(4));
            thread5.Start(new Horse(5));
            thread6.Start(new Horse(6));
            thread7.Start(new Horse(7));
            thread8.Start(new Horse(8));
            thread9.Start(new Horse(9));
            thread10.Start(new Horse(10));
        }

        public static void Run(object horse)
        {
            Horse newHorse = (Horse) horse;

            for (int i = 5; i >= 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }

            Console.WriteLine($"Лошадка с номером {newHorse.id} финишировала");
        }
    }
}
