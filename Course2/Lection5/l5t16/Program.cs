using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5t16
{
    /*
     * Сделайте так, чтобы класс LazyCat умел делать всё тоже самое, что и класс Cat и результат
     * их работы был бы идентичным.
     * Шаблон класса Cat изменять нельзя.
     */

    public class Cat
    {
        public virtual void Say()
        {
            Console.WriteLine("Я старый кот и умею говорить!");
        }

        public virtual string Write()
        {
            return "Я старый кот и умею писать!";
        }

        public virtual int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
