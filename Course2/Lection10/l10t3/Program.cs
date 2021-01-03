using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l10t3
{
    /*
     * Внутри класса Program создайте публичный делегат Say, удовлетворяющий логике
     * работы метода Main().
     * Запустите внутри метода Main() созданный экземпляр делегата, чтобы метод Main()
     * стал работать в соответствии с логикой программы.
     */

    public class Program
    {
        public delegate void Say();
        public static void Main(string[] args)
        {
            Say say = null;
            Console.WriteLine("Введите число от 1 до 3");
            int a = Int32.Parse(Console.ReadLine());
            if (a == 1)
            {
                say = CatLine;
                say();
            }
            if (a == 2)
            {
                say = DogLine;
                say();
            }
            if (a == 3)
            {
                say = FLine;
                say();
            }
        }

        public static void CatLine()
        {
            Console.WriteLine("Сила в котиках!");
        }

        public static void DogLine()
        {
            Console.WriteLine("Сила в собачках!");
        }

        public static void FLine()
        {
            Console.WriteLine("Сила в Ньютонах!");
        }
    }
}
