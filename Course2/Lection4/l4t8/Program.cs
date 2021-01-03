using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace l4t8
{
    /*
     * Создайте в отдельном файле атрибут RandomBreedAttribute, который содержит:
     *      1) Приватный статический массив строк allBreeds.
     *      2) Публичный метод GetBreed(), который ничего не принимает и возвращает случайное
     *         значение из массива allBreeds.
     *      3) Конструктор, принимающий массив строк и присваивающий их полю allBreeds.
     * Атрибут должен быть применим только к полям класса.
     * Для класса Cat пометьте его поле breed созданным атрибутом с произвольным значением пород (но не менее 3) 
     * и переопределите для класса Cat логику работы конструктора по умолчанию таким образом, чтобы он 
     * устанавливал значение поля breed одним из случайных значений созданного атрибута.
     */

    public class Cat
    {
        [RandomBreed(new []{"SFINKS", "MAINKON", "BASE"})]
        public string breed;
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Cat cat1 = new Cat();
            Cat cat2 = new Cat();
            Cat cat3 = new Cat();
            Cat cat4 = new Cat();
            Cat cat5 = new Cat();

            Console.WriteLine(cat1.breed);
            Console.WriteLine(cat2.breed);
            Console.WriteLine(cat3.breed);
            Console.WriteLine(cat4.breed);
            Console.WriteLine(cat5.breed);
        }

        public Cat()
        {
            breed = typeof(Cat).GetField("breed").GetCustomAttribute<RandomBreedAttribute>().GetBreed();
        }
    }

    /* Добавьте свой код ниже */
}
