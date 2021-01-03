using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace l6t16
{
    /*
     * Внутри класса Program создайте 3 статических целочисленных переменных r1, r2, r3.
     * Создайте 3 публичных статических метода M1, M2, M3, каждый из которых считывает с клавиатуры
     * строки до тех пор, пока не введено целое число, после чего присваивает их соответствующим
     * переменных класса Program.
     * Внутри метода Main() запустите каждый из созданных методов в отдельном потоке, после чего:
     * выведите в консоль фразу "Результат суммы переменных r1, r2, r3 = XXX", где ХХХ - значение
     * суммы соответствующих статических переменных.
     */

    public class Program
    {
        public static int r1;
        public static int r2;
        public static int r3;
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */

            List<Thread> threads = new List<Thread>
            {
                new Thread(M1),
                new Thread(M2), 
                new Thread(M3)
            };

            for (int i = 0; i < threads.Count; i++)
            {
                threads[i].Start();
                threads[i].Join();
            }

            Console.WriteLine($"Результат суммы переменных r1, r2, r3 = {r1 + r2 + r3}");
        }

        public static void M1()
        {
            var str = Console.ReadLine();
            while (true)
            {
                if (int.TryParse(str, out r1))
                {
                    break;
                }

                str = Console.ReadLine();
            }
        }

        public static void M2()
        {
            var str = Console.ReadLine();
            while (true)
            {
                if (int.TryParse(str, out r2))
                {
                    break;
                }

                str = Console.ReadLine();
            }
        }

        public static void M3()
        {
            var str = Console.ReadLine();
            while (true)
            {
                if (int.TryParse(str, out r3))
                {
                    break;
                }

                str = Console.ReadLine();
            }
        }
    }
}
