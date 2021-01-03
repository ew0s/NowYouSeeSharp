using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace l7t2
{
    /*
     * Реализуйте метод SmartPrinter() таким образом, чтобы он считывал из консоли строку, после чего:
     *      1) Если получено число, выводил в консоль его в третьей степени.
     *      2) Если получена строка, содержащая только заглавные буквы, выводил строку в консоль.
     *      3) Если получена строка, содержащая только буквы в разных регистрах, выводил в консоль
     *         полученную строку, все символы которой имеют обратный регистр.
     *      4) Во всех остальных случаях поток, в котором работает метод SmartPrinter(), должен завершаться аварийно.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Thread thread = new Thread(SmartPrinter);
            thread.Start();
        }

        public static void SmartPrinter()
        {
            var input = Console.ReadLine();

            if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
            {
                var thread = Thread.CurrentThread;
                thread.Abort();
            }
            else
            {

                if (int.TryParse(input, out var result))
                {
                    Console.WriteLine(Math.Pow(result, 3));
                    return;
                }

                var compareString = input.ToUpper();
                if (compareString == input)
                {
                    Console.WriteLine(input);
                    return;
                }

                compareString = input.ToLower();
                if (compareString == input)
                {
                    var thread = Thread.CurrentThread;
                    thread.Abort();
                }
                else
                {
                    var newString = "";
                    foreach (var symbol in input)
                    {
                        if (char.IsLower(symbol)) newString += char.ToUpper(symbol);
                        if (char.IsUpper(symbol)) newString += char.ToLower(symbol);
                    }

                    Console.WriteLine(newString);
                    return;
                }

                var curThread = Thread.CurrentThread;
                curThread.Abort();
            }
        }
    }
}
