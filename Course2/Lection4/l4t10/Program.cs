using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace l4t10
{
    /*
     * Создайте атрибут MarkAttribute так, чтобы его конструктор принимал строковое значение и устанавливал
     * полученное значение публичной переменной currentMark соответствующего типа. Сделайте так, чтобы атрибут
     * был применим к классам и полям класса.
     * 
     * Внутри класса Program создайте публичную статическую переменную  list, являющуюся динамическим массивом и
     * инициализируйте её, пометив её атрибутом MarkAttribute со значением: SmartContract721.
     * Внутри класса Program создайте статический метод AccountFilter(), который:
     *      1) Ничего не возвращает.
     *      2) Принимает экземпляры общего базового класса.
     *      3) Помещает экземпляр класса в динамический массив list в том случае, если тип экземпляра класса обладает
     *         таким же значением атрибута MarkAttribute, что и list.
     * Создайте произвольный пустой класс и реализуйте его таким образом, чтобы его экземпляры попадали в переменную list.
     */

    public class Program
    {
        [Mark("SmartContract721")]
        public static ArrayList list = new ArrayList();

        public static void AccountFilter(object someObject)
        {
            var objectAttribute = someObject.GetType().GetCustomAttribute(typeof(MarkAttribute));
            var listAttribute = (MarkAttribute)typeof(Program).GetField("list").GetCustomAttribute(typeof(MarkAttribute));

            if (objectAttribute != null)
            {
                var attributeValue = (MarkAttribute)objectAttribute;
                if (attributeValue.currentMark == listAttribute.currentMark)
                {
                    list.Add(someObject);
                }
            }
        }

        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            AccountFilter(new Test());

            foreach (var VARIABLE in list)
            {
                Console.WriteLine(VARIABLE);
            }
        }
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Field)]
    public class MarkAttribute : Attribute
    {
        public string currentMark;
        public MarkAttribute(string s)
        {
            currentMark = s;
        }
    }

    [Mark("SmartContract721")]
    public class Test
    {

    }
}
