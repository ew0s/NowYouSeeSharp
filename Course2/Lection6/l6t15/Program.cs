using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace l6t15
{
    /*
     * Реализуйте класс Horse, внутри которого создайте целочисленное поле id и соответствующий конструктор класса. 
     * Определите в классе Horse метод Run(), который с интервалом в 1 секунду отсчитывает числа от 5 до 0,
     * после чего выводит на экран надпись: "Лошадка с номером XXX финишировала", где ХХХ значение поля id,
     * полученного в качестве входящего параметра, экземпляра класса. 
     * Внутри метода Main() создайте 10 лошадок в отдельных потоках и запустите их. 
     * Сделайте так, чтобы после того как все лошадки финишировали в консоль выводилась фраза 
     * "Заезд завершен. ID победителя: ХХХ!", где ХХХ - значение поля id для победителя текущего заезда.
     * Использовать метод расширения ForEach() нельзя.
     */


    public class Horse
    {
        public static Horse Winner;
        public int id;
        public Horse(int id)
        {
            this.id = id;
        }
        public void Run(object h)
        {
            for (int i = 5; i >= 0; i--)
            {
                if (i == 0)
                {
                    Console.WriteLine($"Лошадка с номером {(h as Horse).id} финишировала");
                    if (Winner == null)
                    {
                        Winner = this;
                    }
                }
                Thread.Sleep(1000);
            }
        }
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Thread thread;
            for (int i = 0; i < 10; i++)
            {
                Horse h = new Horse(i);
                thread = new Thread(new ParameterizedThreadStart(h.Run));
                thread.Start(h);
                if (i == 9) 
                { 
                    thread.Join();
                }
            }
            Console.WriteLine($"Заезд завершен. ID победителя: {Winner.id}!");
            Winner = null;
        }
    }
}
