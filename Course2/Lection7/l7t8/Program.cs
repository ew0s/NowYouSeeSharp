using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace l7t8
{
    /*
     * Метод Describe() работает в многопоточном режиме. Сейчас логика его работы 
     * корректная, а вот вывод в консоль - не очень! Проанализируй код программы
     * и внеси изменения так, чтобы вывод стал соответствовать ожидаемому.
     * Шаблон класса Cat изменять нельзя.
     */

    public class Program
    {
        public static object MagicBall = new object();
        public static object MagicBall2 = new object();
        public static void Main(string[] args)
        {
            lock (MagicBall)
            {
                for (int i = 0; i < 10; i++)
                {
                    new Thread(Describe).Start(new Cat("Котик " + i + 1));
                }   
            }
        }

        public static void Describe(object o)
        {
            lock (MagicBall2)
            {
                var cat = (Cat)o;
                for (int i = 0; i < 13; i++)
                {
                    Console.Write(cat.description[i]);
                    if (i + 1 == cat.description.Count) Console.WriteLine();
                }   
            }
        }
    }
}
