using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace l6t21
{
    /*
     * Реализуйте программу таким образом, чтобы каждый из методов GetString считывал с клавиатуры
     * строку, после чего внутри метода Main() выводилась общая получившаяся фраза, состоящая из
     * считанных строк, разделенных пробелом.
     * Каждый из методов должен запускаться внутри метода Main() в отдельном потоке, а итоговую фразу
     * в консоль должен выводить метод Main(). Порядок формирования итоговой строки должен соответствовать
     * порядковому номеру метода GetString, при этом использовать метод Join запрещено.
     */

    public class Program
    {
        public static string s1;
        public static string s2;
        public static string s3;

        public static bool s1Finished;
        public static bool s2Finished;
        public static bool s3Finished;
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Thread thread1 = new Thread(GetString1);
            Thread thread2 = new Thread(GetString2);
            Thread thread3 = new Thread(GetString3);

            thread1.Start();
            while (true)
            {
                if (s1Finished)
                {
                    break;
                }

                Thread.Sleep(1000);
            }

            thread2.Start();
            while (true)
            {
                if (s2Finished)
                {
                    break;
                }

                Thread.Sleep(1000);
            }

            thread3.Start();
            while (true)
            {
                if (s3Finished)
                {
                    break;
                }

                Thread.Sleep(1000);
            }

            Console.WriteLine(s1 + " " + s2 + " " + s3);
        }

        public static void GetString1()
        {
            s1 = Console.ReadLine();
            s1Finished = true;
        }

        public static void GetString2()
        {
            s2 = Console.ReadLine();
            s2Finished = true;
        }

        public static void GetString3()
        {
            s3 = Console.ReadLine();
            s3Finished = true;
        }
    }
}
