using System;
using System.Threading;

namespace l7t10
{
    public class FastSmartCat
    {
        public void Counter()
        {
            
                Console.WriteLine($"{Thread.CurrentThread.Name} вызывает метод Counter()");
                var outString = "";
                for (int i = 1; i <= 10; i++)
                {
                    if (i == 10)
                    {
                        Console.Write($"{i}");
                        continue;
                    }

                    Console.Write($"{i}, ");
                    Thread.Sleep(100);
                }

                Console.WriteLine();
        }
    }
}
