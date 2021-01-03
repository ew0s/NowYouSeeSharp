using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5t15
{
    /*
     * Для всех наследников класса Animal создайте по 1  конструктору, который принимает 2 параметра:
     *      1) 1 - соответствующий единственному полю определённому в классе.
     *      2) 2 - значение, соответствующее параметру конструктора базового класса, при этом:
     *         2.1) При создании мышки - также для неё должно инициализироваться поле отвечающее за
     *              её врага - произвольный экземпляр класса кошки.
     *         2.2) При создании кошки - также для неё должно инициализироваться поле отвечающее за
     *              её возраст - произвольное значение от 1 до 99.
     *         2.3) При создании собачки - также для неё должно инициализироваться поле отвечающее за
     *              её расположение - пустая строка.
     * Начальные шаблоны классов не должны изменяться, а классы наследники должны иметь лишь 1 конструктор,
     * соответствующий условию задачи.
     */

    public class Animal
    {
        public string Location { get; set; }
        public int Age { get; set; }
        public Animal Enemy { get; set; }

        public Animal()
        {

        }

        public Animal(string location)
        {
            Location = location;
        }

        public Animal(int age)
        {
            Age = age;
        }

        public Animal(Animal enemy)
        {
            Enemy = enemy;
        }
    }

    public class Cat : Animal
    {
        public string Name { get; set; }

        public Cat(string name, int age) : base(age)
        {
            Name = name;
        }
    }

    public class Dog : Animal
    {
        public int Speed { get; set; }

        public Dog(int speed, string location) : base("")
        {
            Speed = speed;
        }
    }

    public class Mouse : Animal
    {
        public bool IsCool { get; set; }

        public Mouse(bool isCool, Cat enemy) : base(enemy)
        {
            IsCool = isCool;
        }
    }
}
