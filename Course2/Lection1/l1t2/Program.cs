using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l1t2
{
    /*
     * Даны два класса: Feline и Animal. Определите, какой из них является более абстрактным, после чего:
     *      1) Сделайте его публичным.
     *      2) Оставьте внутри него лишь те переменные, которые отвечают за абстрактные описательные элементы.
     * Второй класс оставьте без изменений.
     */

    public class WildWorld
    {
        class Feline
        {
            int polulationCount;
            //string color;
            //int weight;
            int averageWeight;
            string shortName;
            int maxLifetime;
            int habitat;
        }

        public class Animal
        {
            //int polulationCount;
            string color;
            int weight;
            //int averageWeight;
            //string shortName;
            //int maxLifetime;
            //int habitat;
        }
    }
}
