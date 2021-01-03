using System;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace l7t7
{
    /*
     * Метод Describe() работает в многопоточном режиме. Сейчас логика его работы 
     * не вполне корректная, а вывод в консоль и подавно! Проанализируйте код программы
     * и внесите изменения так, чтобы вывод стал соответствовать ожидаемому.
     * Шаблон метода Main() и класса Cat изменять нельзя.
     */

    public class Program
    {
        public static object MagicBall = new object();
        public static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                new Thread(Describe).Start(new Cat());
            }
        }

        public static void Describe(object o)
        {
            lock (MagicBall)
            {
                ((Cat)o).Talk();   
            }
        }
    }
}
