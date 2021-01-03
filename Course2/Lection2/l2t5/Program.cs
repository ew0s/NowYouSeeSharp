using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2t5
{
    /*
     * Внутри метода Main() создайте по одному экземпляру класса Cat, Dog и Duck и добавьте их 
     * в коллекцию animals класса Zoo. 
     * Внутри метода Main() для всех элементов коллекции animals вызовите метод SayHello().
     * Сделайте так, чтобы логика работы метода SayHello() соответствовала логике поведения созданных
     * экземпляров класса.
     */

    public class Zoo
    {
        static List<Animal> animals = new List<Animal>();

        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Cat cat = new Cat();
            Dog dog = new Dog();
            Duck duck = new Duck();

            animals.Add(cat);
            animals.Add(duck);
            animals.Add(dog);

            foreach (var animal in animals)
            {
                animal.SayHello();
            }
        }
    }
}
