using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace l9t17
{
    /*
     * Создайте публичный класс Dog, который должен содержать два публичных свойства: Id и Description, тип определите сами.
     * Создате публичный статический метод GetDogDictionary(), который должен:
     *      1) Принимать целое число в качестве параметра.
     *      2) Создавать словарь экземпляров класса Dog, в качестве ключа используя Id, а значения - ссылку на новый созданный экземпляр.
     *      3) Заполнить словарь созданными экземплярами класса Dog в количестве, равному значению принятого параметра. Все Id должны быть различными.
     * Переопределить для класса Dog метод ToString() таким образом, чтобы бы он выводил информацию об экземпляре класса в следующем формате:
     * "Я красивая собачка и мой id=XXX!", где ХХХ - значения параметра Id экземпляра класса Dog.
     * Внутри метода Main() создайте переменную, содержащую результат вызова метода GetDogDictionary(). Значение аргумента - считать с клавиатуры.
     * Выведите в консоль содержимое словаря (каждое значение с новой строки) следующем формате:
     * "ID:KEY , Content: VALUE", где key и value соответствующие значения словаря.
     * Если при вызове метода GetDogDictionary() было использовано отрицательное значение - метод должен вернуть пустую ссылку. 
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Dictionary<int, Dog> dogs = Dog.GetDogDictionary(Convert.ToInt32(Console.ReadLine()));

            if (dogs == null)
            {
                Console.WriteLine("");
            }
            else
            {
                foreach (KeyValuePair<int, Dog> dog in dogs)
                {
                    Console.WriteLine($"ID:{dog.Key} , Content: {dog.Value}");
                }
            }
        }
    }

    public class Dog
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public static Dictionary<int, Dog> GetDogDictionary(int number)
        {
            if (number < 0)
            {
                return null;
            }

            Dictionary<int, Dog> outDogs = new Dictionary<int, Dog>();
            for (int i = 0; i < number; i++)
            {
                Dog tmp = new Dog();
                tmp.Id = i;
                outDogs.Add(i, tmp);
            }

            return outDogs;
        }

        public override string ToString()
        {
            return $"Я красивая собачка и мой id={Id}!";
        }
    }
}
