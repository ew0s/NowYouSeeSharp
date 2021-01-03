using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l4t5
{
    /*
     * Создайте в отдельных файлах 3 атрибута: MagicMethodAttribute, MagicClassAttribute, MagicFieldAndPropertуAttribute.
     * Задайте каждому из созданных атрибутов ограничение по области применения, исходя из логики их названий.
     * Пометьте каждый из элементов класса World  соответствующим атрибутом.
     */

    [MagicClass]
    public class World
    {
        [MagicFieldAndPropertу]
        public string Name { get; set; }
        [MagicFieldAndPropertу]
        public int age;
        [MagicFieldAndPropertу]
        public static int population;

        [MagicMethod]
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
        }

        [MagicMethod]
        public void Spin(string direction)
        {
            Console.WriteLine("И всё-таки она вертится!");
        }
    }
}
