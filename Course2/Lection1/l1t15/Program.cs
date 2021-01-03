using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l1t15
{
    /*
     * Внутри класса Zoo объявлены классы. Выстройте правильную цепочку связей для 
     * них с использованием механизмов наследования.
     * 
     * Класс Zoo участия в наследовании не принимает!
     */

    public class Zoo
    {
        class Animals
        {

        }

        class Cat : Cats
        {

        }

        class Predators : Mammals
        {

        }

        class Cats : Felines
        {

        }

        class Mammals : Animals
        {

        }

        class Barsik : Cat
        {

        }

        class Felines : Predators
        {

        }
    }
}
