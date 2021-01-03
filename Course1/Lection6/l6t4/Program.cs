using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l6t4
{
    /*
     * Создайте класс Human, который должен содержать свойства: имя(name), пол(sex), возраст(age). Свойство пол сделайте
     * логического типа, на основе следующей формальной логики: true - мужской пол, false - женский. Типы остальных
     * свойств класса определите самостоятельно.Все элементы класса Human должны быть публичными.
     * Переопределите метод ToString() класса Human, так чтобы он выводил информацию об экземпляре класса в следующем формате:
     * "Меня зовут ХХХ, я мужчина\женщина, мне ХХХ лет.", где ХХХ - соответствующие значения свойств класса Human,
     * а выбор значения мужчина\женщина зависел от значения свойства, отвечающего за пол.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    /* Добавьте свой код ниже */
    public class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Sex { get; set; }


        public override string ToString()
        {
            return Sex ? $"Меня зовут {Name}, я мужчина, мне {Age} лет." : $"Меня зовут {Name}, я женщина, мне {Age} лет.";
        }
    }
}
