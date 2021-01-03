using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using l2t20.Animals;

namespace l2t20
{
    /*
     * Внутри класса Animal создайте и реализуйте статический метод GetCorrectObject(), который:
     *      1) Принимает целое число в качестве входящего параметра.
     *      2) Возвращает экземпляр такого класса, вес которого наиболее подходит под значение переданного
     *         параметра.
     *      3) Тип возвращаемого значения - базовый для всех экземпляров.
     * Используйте такую логику определения типа объекта, где средний вес экземпляра равен:
     *      1) для собаки - 15
     *      2) для утки - 3
     *      3) для лошади - 100
     *      4) для кота - 7
     *      5) для обезьяны - 50
     * Метод GetCorrectObject() должен руководствоваться следующими принципами при определении типа возвращаемого
     * объекта:
     *      1) Передаваемый параметр - это требуемый вес животного.
     *      2) В случае получения отрицательного или нулевого значения - необходимо выбрасывать новый экземпляр
     *         исключения, указывающего на то, что при данном значении аргумента указанная операция не может быть совершена.
     *      3) В случае, если переданное значение аргумент точно не совпадает с каким-либо из показателей веса, то искомым животным
     *         должно являться такое животное, которое имеет наиболее близкое значение веса.
     *      4) В случае если для двух животных показатель "удалённости" веса от переданного значения равен - предпочтение должно отдаваться
     *         животному с меньшим весом.
     */

    public class Animal
    {
        protected string name;
        protected int weight;
        protected int age = 100;

        public static void Main(string[] args)
        {
            
        }

        public static Animal GetCorrectObject(int weight)
        {
            if (weight <= 0)
            {
                throw new ArgumentException();
            }

            int weightToDog = Math.Abs(15 - weight);
            int weightToDuck = Math.Abs(3 - weight);
            int weightToHorse = Math.Abs(100 - weight);
            int weightToCat = Math.Abs(7 - weight);
            int weightToMonkey = Math.Abs(50 - weight);

            int closetWeight = (new HashSet<int>() {weightToMonkey, weightToCat, weightToDog, weightToDuck, weightToHorse}).Min();

            if(Math.Abs(3 - weight) == closetWeight)
            {
                return new Duck("DUCK", 12, 12);
            }
            if(Math.Abs(7 - weight) == closetWeight)
            {
                return new Cat("CAT", 12, 12);
            }

            if(Math.Abs(15 - weight) == closetWeight)
            {
                return new Dog("DOG", 12, 12);
            }

            if(Math.Abs(50 - weight) == closetWeight)
            {
                return new Monkey("MONKEY", 12, 12);
            }
            return new Horse("HORSE", 12, 12);
        }

        public Animal(string name, int weight, int age)
        {
            this.name = name;
            this.weight = weight;
            this.age = age;
        }

        /* Добавьте свой код ниже */
    }
}
