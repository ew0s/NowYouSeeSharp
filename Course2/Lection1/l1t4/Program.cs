using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l1t4
{
    /*
     * Наше восприятие и наше описание делают из абстракции конкретный предмет и наоборот.
     * 
     * Внутри класса Program даны поля, описывающие котиков. Используя эти поля, создайте:
     *      1) Два публичных класса Cat и MainCoon в том же неймспейсе, что и класс Program
     *      2) Добавьте в класс Cat только конкретные поля из класса Program
     *      3) Добавьте в класс MainCoon только абстрактные поля из класса Program
     */

    public class Program
    {
    }

    public class Cat
    {
        public int legsCount;
        public int maxLifeTimeDuration;
        public int tailsCount;
        public string catName;
        public string ownerName;
    }

    public class MainCoon
    {
        public int weight;
        public int speed;
        public string breed;
        public string age;
    }
}
