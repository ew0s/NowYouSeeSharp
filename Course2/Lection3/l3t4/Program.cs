using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3t4
{
    /*
     * В отдельных файла создайте 3 интерфейса: IMovable, ISwimmable, IFlyable. Для каждого из
     * созданных интерфейсов добавьте:
     *      1) Метод, который ассоциируется с названием интерфейса который ничего не принимает и ничего не возвращает.
     *      2) Перегрузку первого метода интерфейса, которая принимает значение перечисления Mode и ничего не возвращает.
     * Реализуйте для класса Duck все три созданных интерфейса, таким образом чтобы:
     *      1) Первый метод каждого интерфейса выводил в консоль фразу "Я ХХХ!", где ХХХ - характеризует 
     *         текущее действие экземпляра класса, реализующего интерфейс. (например для IMovable "Я иду!").
     *      2) Второй метод каждого интерфейса выводил в консоль фразу в формате "Я ХХХ YYY!", где ХХХ и YYY - 
     *         характеризуют действия экземпляра класса, реализующего интерфейс, с учетом переданного параметра. 
     *         (например для IMovable "Я иду быстро!").
     * Внутри метода Main() создайте 1 экземпляр класса Duck и последовательно вызовите для него по 1 произвольному методу
     * из каждого реализуемого интерфейса.
     */

    public class Duck : IMovable, ISwimmable, IFlyable
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Duck duck = new Duck();
            duck.Fly(Mode.Fast);
            duck.Move(Mode.Fast);
            duck.Swim(Mode.Fast);
        }

        public void Move()
        {
            Console.WriteLine("Я иду!");
        }

        public void Move(Mode mode)
        {
            switch (mode)
            {
                case Mode.Fast:
                    Console.WriteLine("Я иду быстро!");
                    break;
                case Mode.Slow:
                    Console.WriteLine("Я иду медленно!");
                    break;
            }
        }

        public void Swim()
        {
            Console.WriteLine("Я плыву!");
        }

        public void Swim(Mode mode)
        {
            switch (mode)
            {
                case Mode.Fast:
                    Console.WriteLine("Я плыву быстро!");
                    break;
                case Mode.Slow:
                    Console.WriteLine("Я плыву медленно!");
                    break;
            }
        }

        public void Fly()
        {
            Console.WriteLine("Я лечу!");
        }

        public void Fly(Mode mode)
        {
            switch (mode)
            {
                case Mode.Fast:
                    Console.WriteLine("Я лечу быстро!");
                    break;
                case Mode.Slow:
                    Console.WriteLine("Я лечу медленно!");
                    break;
            }
        }
    }

    public enum Mode
    {
        Slow,
        Fast
    }
}
