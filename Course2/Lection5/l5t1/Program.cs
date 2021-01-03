using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5t1
{
    /*
     * Внутри метода Main() сделайте так, чтобы результат вызова метода AnimalPrinter для каждого
     * из созданных экземпляров стал соответствовать их типу.
     * Остальные элементы шаблона изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            Animal cat = new Cat("Барсик");
            Animal cow = new Cow("Бурёнка");
            Animal animal = new Animal("Лягушка");

            AnimalPrinter((Cat)cat);
            AnimalPrinter((Cow)cow);
            AnimalPrinter(animal);
        }

        public static void AnimalPrinter(Animal a)
        {
            Console.WriteLine("Зверюшку зовут " + a);
        }

        public static void AnimalPrinter(Cat a)
        {
            Console.WriteLine("Котика зовут " + a);
        }

        public static void AnimalPrinter(Cow a)
        {
            Console.WriteLine("Коровку зовут " + a);
        }
    }
}
