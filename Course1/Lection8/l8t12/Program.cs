using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l8t12
{
    /*
     * Внутри метода Main() отсортируйте список экземпляров класса DogClient в порядке убывания. Критерии сортировки:
     *      1) По возрасту.
     *      2) Если возраст экземпляров равен, то они должны сортироваться между собой в порядке убывания их веса.
     *      3) Если возраст и вес равны, то они должны идти в том же порядке, в котором они добавлены в список.
     * Шаблон задачи изменять нельзя.
     */

    public class DogBank
    {
        public static List<DogClient> dogClientList = new List<DogClient>()
        {
            new DogClient("Барбос",1,5),
            new DogClient("Тризор",2,1),
            new DogClient("Ревизор",1,5),
            new DogClient("Терьер",2,5),
            new DogClient("Киллер",2,3),
            new DogClient("Бутч",3,7),
            new DogClient("Рекс",5,5),
        };

        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            IOrderedEnumerable<DogClient> sortedDogClients = dogClientList.OrderByDescending(u => u.Age).ThenByDescending(u => u.Weight);

            int i = 0;
            foreach (DogClient dogClient in sortedDogClients)
            {
                dogClientList.Remove(dogClientList[0]);
                dogClientList.Add(dogClient);
            }

            foreach (DogClient dogClient in dogClientList)
            {
                Console.WriteLine(dogClient);
            }
        }
    }

    public class DogClient
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }

        public DogClient(string name, int age, int weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"Я собачка {Name}! Мне {Age} лет и я вешу {Weight}!";
        }
    }
}
