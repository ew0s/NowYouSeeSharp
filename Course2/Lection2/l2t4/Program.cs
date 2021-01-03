using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace l2t4
{
    /*
     * Внутри класса Program создайте типизированную коллекцию уникальных элементов, которые могли
     * бы принимать все экземпляры классов Cat, Mouse, Dog и Animal и поместите её в статическое свойство
     * UniqueSet.
     * Внутри метода Main() создайте по одному экземпляру классов Cat, Mouse, Dog, Animal и поместите их
     * в коллекцию UniqueSet.
     */

    public class Program
    {
        /* Добавьте свой код ниже */
        private HashSet<Animal> uniqueSet;

        public static HashSet<Animal> UniqueSet { get; set; }

        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Animal animal = new Animal();
            Cat cat = new Cat();
            Dog dog = new Dog();
            Mouse mouse = new Mouse();

            UniqueSet = new HashSet<Animal>();
            UniqueSet.Add(animal);
            UniqueSet.Add(cat);
            UniqueSet.Add(dog);
            UniqueSet.Add(mouse);
        }
    }
}
