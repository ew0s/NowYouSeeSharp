using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3t22
{
    /*
     * Сейчас в логике наследственных связей есть некоторый сумбур. Исправьте его так, чтобы:
     *      1) Программа скомпилировалась
     *      2) Класс Cat имел только одного явного предка в строке объявления класса.
     *      3) Класс Cat должен поддерживать реализацию всех интерфейсов в программе.
     */

    public class Cat : Animal
    {
        public override void Fly()
        {
            Console.WriteLine("Плиз не надо...");
        }

        public override void Meow()
        {
            Console.WriteLine("Мяу");
        }
    }
}
