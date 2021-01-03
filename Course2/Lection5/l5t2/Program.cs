using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5t2
{
    /*
     * Создайте публичный статический метод CorrectPrint(), который:
     *     1) Ничего не возвращает.
     *     2) Считывает с консоли данные, пока не введено слово end.
     *     3) Для каждого введенного значения, вызывает метод Print():
     *        3.1) Если в строке содержится дробное число – вызвался метод Print() для double.
     *        3.2) Если число в строке больше нуля, но меньше 128 – вызвался Print() для short.
     *        3.3) Если число в строке меньше либо равно нулю или больше 128 -  методы Print() для int.
     *        3.4) Во всех остальных случаях должен вызываться метод Print() для string.
     * Базовый шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            CorrectPrint();
        }

        public static void CorrectPrint()
        {
            var input= Console.ReadLine();
            while (input != "end")
            {
                if (string.IsNullOrEmpty(input))
                {
                    input = Console.ReadLine();
                    continue;
                }

                if (int.TryParse(input, out var intTmpValue))
                {
                    if (intTmpValue > 0 && intTmpValue < 128)
                    {
                        Print((short)intTmpValue);
                    }
                    else
                    {
                        Print(intTmpValue);
                    }
                }
                else if (double.TryParse(input, out var doubleTmpValue))
                {
                    Print(doubleTmpValue);
                }
                else
                {
                    Print(input);
                }

                input = Console.ReadLine();
            }
        }

        public static void Print(double value)
        {
            Console.WriteLine("Это тип Double, значение " + value);
        }

        public static void Print(string value)
        {
            Console.WriteLine("Это тип String, значение " + value);
        }

        public static void Print(short value)
        {
            Console.WriteLine("Это тип Short, значение " + value);
        }

        public static void Print(int value)
        {
            Console.WriteLine("Это тип Integer, значение " + value);
        }
    }
}
