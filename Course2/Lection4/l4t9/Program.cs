using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace l4t9
{
    /*
     * Создайте атрибут AllowAccessAttribute который содержит:
     *      1) Публичное свойство IsAllow логического типа.
     *      2) Конструктор, принимающий и устанавливающий значение IsAllow.
     *      3) Применим только для класса.
     * Внутри класса Program создайте:
     *      1) Два приватных динамических массива: whiteList и blackList.
     *      2) Публичный статический метод ObjectSorter(), который:
     *         2.1) Ничего не возвращает.
     *         2.2) Принимает динамический массив и экземпляр класса Program.
     *         2.3) Распределяет все элементы полученного массива по whiteList и blackList экземпляра на основе
     *              следующей формальной логики: в whiteList попадают все объекты, значение атрибута 
     *              AllowAccess которых является истинным, а все остальные попадают в список blackList.
     * Сделайте так, чтобы лишь экземпляры классов Cat и Dog попадали в whiteList.
     */

    public class Program
    {
        private ArrayList whiteList = new ArrayList(); 
        private ArrayList blackList = new ArrayList();
        public static void Main(string[] args)
        {
            Program p = new Program();
            ObjectSorter(new ArrayList()
            {
                new Cat(),
                new Dog(),
                new Ball()
            }, p);

            foreach (var VARIABLE in p.blackList)
            {
                Console.WriteLine(VARIABLE);
            }

            Console.WriteLine();

            foreach (var VARIABLE in p.whiteList)
            {
                Console.WriteLine(VARIABLE);
            }
        }

        public static void ObjectSorter(ArrayList arrayList, Program program)
        {
            foreach (var value in arrayList)
            {
                var attribute = value.GetType().GetCustomAttribute(typeof(AllowAccessAttribute));
                if (attribute != null)
                {
                    var attributeValue = (AllowAccessAttribute) attribute;

                    if (attributeValue.IsAllow && (value is Cat || value is Dog))
                    {
                        program.whiteList.Add(value);
                    }
                }
                else
                {
                    program.blackList.Add(value);
                }
            }
        }
    }
}
