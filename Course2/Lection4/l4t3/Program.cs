using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace l4t3
{
    /*
     * Пометьте метод Main класса Program атрибутом NYSSAttribute, после чего:
     * Добавьте к атрибуту NYSSAttribute конструктор, который принимает строковый параметр и выводит
     * в консоль следующую строку: "Когда ко мне обратятся - я отработаю ... и выведу: ХХХ", где 
     * ХХХ - значение переданного при вызове аргумента.
     * Шаблон метода Main изменять нельзя.
     */

    public class Program
    {   
        [NYSS("hello")]
        public static void Main(string[] args)
        {
            Console.WriteLine("Изначально атрибут хоть и есть, но он ничего не делает...");
            var info = new Program().GetType().GetMethod("Main").GetCustomAttributes();
            foreach (var item in info)
            {
                Console.WriteLine(item);
            }
        }
    }
}
