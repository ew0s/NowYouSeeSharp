using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2t27
{
    /*
     * Для класса Cat перегрузите оператор явного приведения к большим целым числам.
     * Пусть в результате перегрузки получается число, равно сумме всех числовых полей
     * экземпляра класса.
     */

    public class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public short Weight { get; set; }
        public byte Speed { get; set; }

        public static void Main(string[] args)
        {
          
        }

        /* Добавьте свой код ниже */
        public static explicit operator long(Cat cat)
        {
            return cat.Age + cat.Speed + cat.Weight;
        }
    }
}
