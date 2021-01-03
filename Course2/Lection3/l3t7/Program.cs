using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3t7
{
    /*
     * Внутри класса Program измените тип списка list таким образом, чтобы он мог хранить в себе как можно больше
     * экземпляров классов, объявленных в программе.
     * 
     * Остальные элементы шаблона изменять нельзя.
     */

    public class Program
    {
        public List<IHungry> list = new List<IHungry>();
    }

    public class Animal : IHungry { }
    public interface IHungry { }
    public interface IWalkable { }
    public class Cat : Animal, IWalkable { }
    public class Dog : IHungry { }
    public class Fish : IHungry { }
    public class Bird : Animal { }
    public class Monkey : Animal { }
    public class Human : IWalkable { }
    public class Lion : IWalkable { }
    public class Retriver : Dog { }
    public class MainCoon : Cat, IWalkable { }
    public class Doberman : Dog, IWalkable { }
    public class Duck : Bird, IWalkable { }
    public class Fox : IWalkable { }
}
