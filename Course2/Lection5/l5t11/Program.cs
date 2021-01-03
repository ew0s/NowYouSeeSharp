using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5t11
{
    /*
     * Сделайте класс Lion наследником класса Animal, после чего создайте конструктор для класса Lion,
     * который принимает и устанавливает имя, возраст и скорость экземпляра класса.
     * Шаблон класса Animal изменять нельзя, а класс Lion не должен иметь больше 1 конструктора.
     */

    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
