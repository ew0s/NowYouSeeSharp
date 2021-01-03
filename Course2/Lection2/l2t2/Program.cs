using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2t2
{
    /*
     * Для каждого из классов Cat, Dog, Duck реализуйте свою версию метода Say(), так чтобы
     * в результате его работы в консоль была выведена фраза "Я говорю ХХХ", где ХХХ принимают значения:
     * МЯУ-МЯУ, ГАВ-ГАВ, КРЯ-КРЯ в зависимости от класса.
     * 
     * Наследственные связи между классами нарушать нельзя,так же как и код класса Animal.
     */


    public class Program
    {    
        public static void Main(string[] args)
        {
            new Animal().Say();
            new Dog().Say();
            new Cat().Say();
            new Duck().Say();
        }
    }
}
