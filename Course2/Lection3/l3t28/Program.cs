using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3t28
{
    /*
     * Внутри класс Program создайте 3 публичных статически типизированных списка, каждый из которых должен содержать
     * экземпляры классов Cat, Dog, Animal и иметь имена catList, dogList, animalList соответственно.
     * Создайте в классе Program публичный статический метод AnimalSorter(), который:
     *      1) Принимает массив экземпляров базового класса Animal.
     *      2) Распределяет все принятые экземпляры по соответствующим спискам класса Program.
     *      3) Возвращает строчку, указывающую количество принятых и отсортированных элементов в следующем формате:
     *         "Всего элементов принято: ХХХ. Из них ХХХ собачек, ХХХ кошечек и ХХХ неведомых зверушек...", где 
     *         ХХХ - соответствующие значения элементов, участвующих в сортировке.
     */

    public class Program
    {
        public static List<Cat> catList = new List<Cat>();
        public static List<Dog> dogList = new List<Dog>();
        public static List<Animal> animalList = new List<Animal>();
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Animal[] animals = new Animal[] {new Animal(), new Cat(), new Dog(), };
            Console.WriteLine(AnimalSorter(animals));
        }

        public static string AnimalSorter(Animal[] animals)
        {
            foreach (var animal in animals)
            {
                if (animal is Cat)
                {
                    catList.Add((Cat) animal);
                }
                else if (animal is Dog)
                {
                    dogList.Add((Dog) animal);
                }
                else
                {
                    animalList.Add(animal);
                }
            }

            return
                $"Всего элементов принято: {animals.Length}. Из них {dogList.Count} собачек, {catList.Count} кошечек и {animalList.Count} неведомых зверушек...";
        }
    }
}
