using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace l8t27
{
    /*
     * Внутри метода Main() вызовите метод Invoker() самым первым и убедитесь, что модификатор async не содержит 
     * никакой магии и без дополнительной логики никакой параллельности при выполнении методов не будет!
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Invoker();
            Console.WriteLine("Но не смотря на то, что все методы помечены как async, это не запускает их в отдельном потоке.");
            Console.WriteLine("И код вызова будет синхронным...");
            Console.WriteLine("Мораль: лишь асинхронное выполнение делает ЛЮБОЙ метод асинхронным, а модификатор async лишь указывает на это!");
        }

        public async static void LongMethod()
        {
            Thread.Sleep(4000);
            Console.WriteLine("Медленный метод - работает медленно!");
        }

        public async static void FastMethod()
        {
            Console.WriteLine("Быстрый метод - работает быстро!");
        }

        public async static void Invoker()
        {
            LongMethod();
            FastMethod();
            Console.WriteLine("А я призываю работать все другие методы!");
        }
    }
}
