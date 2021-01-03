using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l1t16
{
    /*
     * Внутри класса Things объявлено 7 классов. Определите между ними наличие наследственных связей, после чего
     * добавьте классам соответствующие связи при помощи наследования.
     * 
     * Сам класс Things в наследственных связях участия не принимает.
     */

    public class Things
    {
        class Cat : Animal
        {

        }

        class Dog : Animal
        {

        }

        class Animal
        {

        }

        class Bird : Animal
        {

        }

        class Car
        {

        }
        class BMW : Car
        {

        }

        class Plane
        {

        }
    }
}
