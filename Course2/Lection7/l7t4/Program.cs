using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace l7t4
{
    /*
     * Для класса Program создайте публичный статический метод ToEasy(), который должен запускать в отдельном потоке 
     * сам себя до тех пор, пока глубина рекурсии не достигнет 50, после чего должен аварийно завершать свой текущий поток.
     */

    public class Program
    {
        [ThreadStatic] public static int count = 1;
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Thread thread = new Thread(ToEasy);
            thread.Start();
        }

        public static void ToEasy()
        {
            if (count > 50)
            {
                Thread.CurrentThread.Abort();
            }

            count++;
            var thread = new Thread(ToEasy);
            thread.Start();
        }
    }
}
