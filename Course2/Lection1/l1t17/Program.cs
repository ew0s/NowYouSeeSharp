using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l1t17
{
    /*
     * Внутри программы установлены наследственные связи, при этом логика наследования нарушена.
     * Проанализируйте текущие связи и исправьте несоответствия.
     */

    public class Animal {}

    public class Dog : Animal{ }
    public class Plane : Machine  { }
    public class Fish : Animal { }
    public class Vobla : Fish { }
    public class Human : Animal { }
    public class Tree { }
    public class Machine { }
    public class Beer { }

}
