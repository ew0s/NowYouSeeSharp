using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l1t10
{
    /*
     * Перенесите класс Mouse в отдельный файл с соответствующим названием.
     * 
     * Сделайте так, чтобы программа скомпилировалась и внутри метода Main() выведите
     * в консоль имена всех созданных экземпляров класса Mouse, каждый с новой строки.
     * 
     * Доступ к имени реализуйте с использованием свойства класса таким образом, чтобы:
     * имя всегда возвращалось с заглавной буквы, а заканчивалось восклицательным знаком.
     * 
     * Базовый шаблон метода Main() и класса Mouse не должен быть изменён.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            Mouse m1 = new Mouse("микки");
            Mouse m2 = new Mouse("Минни");
            Mouse m3 = new Mouse("Турецкий");
            /* Добавьте свой код ниже */
            Console.WriteLine(m1.Name);
            Console.WriteLine(m2.Name);
            Console.WriteLine(m3.Name);
        }
    }
}
