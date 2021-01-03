using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l4t4
{
    /*
     * Создайте в отдельном файле атрибут MyCustomAttribute, добавив в него 3 конструктора:
     *      1) Принимает целочисленное значение.
     *      2) Принимает строковое значение.
     *      3) Принимает логическое значение.
     * Пометьте каждый из элементов класса Program созданным атрибутом, используя произвольный
     * конструктор.
     */

    [MyCustom(12)]
    public class Program
    {
        [MyCustom("HELLO")]
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
        }
    }
}
