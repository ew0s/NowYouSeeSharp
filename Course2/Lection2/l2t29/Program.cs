using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2t29
{
    /*
     * Перегрузите оператор явного приведения для класса Wolf таким образом, чтобы в результате операции
     * получался новый экземпляр класса Sheep, значения полей которого полностью совпадают с исходными.
     */

    public class Wolf
    {
        public string name;
        public int weight;
        public int age;
        public bool haveShinyTeeth;

        /* Добавьте свой код ниже */
        public static explicit operator Sheep(Wolf wolf)
        {
            Sheep sheep = new Sheep();
            sheep.age = wolf.age;
            sheep.haveShinyTeeth = wolf.haveShinyTeeth;
            sheep.name = wolf.name;
            sheep.weight = wolf.weight;

            return sheep;
        }

        public static void Main(string[] args)
        {
            
        }
    }
}
