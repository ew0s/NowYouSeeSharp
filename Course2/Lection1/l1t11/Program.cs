using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace l1t11
{
    /*
     * Создайте в отдельных файлах два публичных класса Cat и Dog, после чего в каждый из классов:
     *      1) Добавьте приватные переменные отвечающие за имя и возраст.
     *      2) Добавьте конструктор класса, принимающий и устанавливающий соответствующие значения имени и возраста.
     *      3) Переопределите логику метода ToString, так чтобы он выводил информацию об экземплярах в следующем формате:
     *         "Меня зовут ХХХ", где ХХХ - имя соответствующего экземпляра класса.
     * 
     * Внутри класса Program:
     *      1) Создайте два приватных статических списка экземпляров классов Cat (catList) и Dog (dogList).
     *      2) Создайте два публичных метода: ToCatList и ToDogList, которые:
     *         2.1) Распределяют по соответствующим спискам все создаваемые экземпляры классов Cat и Dog.
     *         2.2) Ничего не возвращают.
     *      3) Создайте приватный статический метод ShowAllLists, который:
     *         3.1) Ничего не принимает и ничего не возвращает.
     *         3.2) Выводит в консоль все элементы catList и dogList, каждый с новой строки.
     *      4) Сделайте так, чтобы каждый из создаваемых экземпляров классов Cat и Dog всегда попадали в соответствующие списки.
     *            
     * Внутри метода Main(): 
     *      1) Создайте по 3 переменных класса Cat и Dog.
     *      2) Вызовите метод ShowAllLists.
     *      3) Вызывать методы ToCatList() и ToDogList() внутри класса Program запрещено.
     */

    public class Program
    {
        private static List<Cat> catList = new List<Cat>();
        private static List<Dog> dogList = new List<Dog>();
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Cat cat1 = new Cat("MURA", 1);
            Cat cat2 = new Cat("JORA", 1);
            Cat cat3 = new Cat("TOMA", 1);

            Dog dog1 = new Dog("BOBIK", 2);
            Dog dog2 = new Dog("TOBIK", 2);
            Dog dog3 = new Dog("SOPIK", 2);

            ShowAllLists();
            
        }

        public void ToCatList(Cat cat)
        {
            catList.Add(cat);
        }

        public void ToDogList(Dog dog)
        {
            dogList.Add(dog);
        }

        private static void ShowAllLists()
        {
            foreach (var cat in catList)
            {
                Console.WriteLine(cat);
            }

            foreach (var dog in dogList)
            {
                Console.WriteLine(dog);
            }
        }
    }
}
