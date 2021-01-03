using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace l4t11
{
    /*
     * В отдельном файле создайте AuthToken атрибут, который:
     *      1) Содержит приватный статический список строк tokens.
     *      2) Содержит конструктор, который принимает массив строк и добавляет все его строки
     *         в список tokens без повторений.
     *      3) Применим только к методам.
     *      4) Содержит публичный метод Check(), который принимает экземпляр класса CoolCat,
     *         после чего возвращает true если значение token полученного экземпляра класса содержится 
     *         в списке tokens или false в противном случае.
     * Внутри класса Program создайте публичный статический метод CheckCoolCat() который:
     *      1) Принимает экземпляр класса CoolCat.
     *      2) Возвращает true только в случае если значение поля token полученного экземпляра входит
     *         в состав значений атрибута, которым был помечен данный метод.
     * Пометьте метод CheckCoolCat() атрибутом AuthToken, передав в конструктор при вызове массив строк,
     * содержащий как минимум 5 произвольных значений.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            CoolCat coolCat = new CoolCat("Hello");
            Console.WriteLine(CheckCoolCat(coolCat));

        }

        [AuthToken(new []{"Hello", "world", "I am", "Working", "With", "Attributes"})]
        public static bool CheckCoolCat(CoolCat coolCat)
        {
            return typeof(Program).GetMethod("CheckCoolCat").GetCustomAttribute<AuthToken>().Check(coolCat);
        }
    }
}
