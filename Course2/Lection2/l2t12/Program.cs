using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2t12
{
    /*
     * Для классов Vectra и Astra создайте конструктор, который принимает и устанавливает значения:
     * модели, максимальной скорости и веса машины.
     * Переопределите метод ToString() для каждого из классов так, чтобы при его вызове возвращалось
     * следующее представление об экземплярах класса:
     *      1) Для класса Astra "Автомобиль Астра, модель: ХХХ, максимальная скорость: ХХХ, при этом весит всего-лишь: ХХХ тонны!".
     *      2) Для класса Vectra "Автомобиль Vectra, модель: ХХХ, максимальная скорость: ХХХ, а вес составляет: ХХХ тонны!".
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            Vectra vectra = new Vectra("light car", 200, 1.5);
            Astra astra = new Astra("light car", 220, 1);

            Console.WriteLine(vectra);
            Console.WriteLine(astra);
        }
    }
}
