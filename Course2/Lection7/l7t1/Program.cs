using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace l7t1
{
    /*
     * Внутри метода Main() запустите дочерний поток с методом Train(). Дополните метод Main() таким образом, чтобы
     * сразу после запуска дочернего потока он был прерван досрочно.
     * Шаблон задачи изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Thread thread = new Thread(Train);
            thread.Start();
            thread.Interrupt();
        }

        public static void Train()
        {
            Thread.Sleep(100000);
        }
    }
}
