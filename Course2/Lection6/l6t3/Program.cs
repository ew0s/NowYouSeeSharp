using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace l6t3
{
    /*
     * Внутри метода Main() запустите в новых потоках все методы, которые могут быть запущены
     * при условии, что все значения аргумента для запуска должны передаваться внутри метода Start().
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            var p = new Program();
            var thread1 = new Thread(new ThreadStart(CloudPrint));
            var thread2 = new Thread(new ParameterizedThreadStart(CloudPrint));
            var thread3 = new Thread(p.ClоudPrint);

            thread1.Start();
            thread2.Start(100);
            thread3.Start();

        }

        public static void CloudPrint(int a, int b)
        {
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(b);
            }
        }

        public static void CloudPrint(object o)
        {
            Console.WriteLine("Опять работать...");
        }

        public static void CloudPrint(string s, int b)
        {
            for (int i = 0; i < b; i++)
            {
                Console.WriteLine("Кто это тут такой милый? Да этоже : " + s);
            }
        }

        public static void CloudPrint()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Памагити, я не хочу запускаться ...");
            }
        }

        public int CloudPrint(int a)
        {
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(a);
            }
            return 101;
        }

        public void ClоudPrint()
        {
            Console.WriteLine("Опечатки никто не отменял, так что иногда даже так бывает, только никому не говори!");
        }
    }
}
