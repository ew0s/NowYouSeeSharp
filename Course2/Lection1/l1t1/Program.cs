using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l1t1
{
    /*
     * Абстракция и конкретика - две противоположности, которые присущи любым окружающим объектам.
     * Умение отличить одно от другого - один из важнейших навыков хорошего программиста.
     * 
     * Внутри класса Car даны свойства, описывающие элементы и характеристики машины.
     * Измените класс Car так, чтобы внутри него остались лишь абстрактные переменные.
     */

    public class Car
    {
        public int Speed { get; set; }
        public string Color { get; set; }
    }
}
