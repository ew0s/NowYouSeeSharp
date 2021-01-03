using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5t12
{
    /*
     * Установите корректные наследственные связи между всеми классами в программе, за исключением
     * основного класса Zoo.
     * Дополните шаблон конструктора каждого из класса таким образом, чтобы итоговый подсчёт экземпляров
     * в классе Zoo стал корректным, при этом:
     *      1) Базовые строчки, заданные в конструкторах изменять нельзя.
     *      2) Шаблон класса Zoo изменять нельзя.
     */

    public class Zoo
    {
        public static int catPopulation = 0;
        public static int dogPopulation = 0;
        public static int birdPopulation = 0;
        public static int duckPopulation = 0;
        public static int animalPopulation = 0;
        public static int calibriPopulation = 0;

        public static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                new Bird();
                new Animal();
                new Duck();
                new Calibri();
                new Dog();
                new Cat();
            }

            Console.WriteLine(catPopulation);
            Console.WriteLine(dogPopulation);
            Console.WriteLine(birdPopulation);
            Console.WriteLine(animalPopulation);
            Console.WriteLine(duckPopulation);
            Console.WriteLine(calibriPopulation);
        }
    }
}
