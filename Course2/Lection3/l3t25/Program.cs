using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3t25
{
    /*
     * В классе Ship есть некоторая путаница с реализацией интерфейсов. Решите проблему так, чтобы все 3 конфликтных метода
     * стали работать как надо, при этом вносить изменения в связи класса Ship или интерфейсы нельзя.
     */

    public class Ship : IPortBeep, ISeaBeep
    {
        void IPortBeep.Beep()
        {
            Console.WriteLine("Делаем ТУ-ТУ при заходе в порт!");
        }

        void ISeaBeep.Beep()
        {
            Console.WriteLine("Делаем ТУ-ТУ когда видим кораблик!");
        }

        public void Beep()
        {
            Console.WriteLine("Делаем ТУ-ТУ потому что могу...");
        }
    }
}
