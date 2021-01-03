using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3t8
{
    /*
     * Класс Human реализует некоторое количество интерфейсов, при этом часть из них реализуется явно не корректно.
     * Определите какие именно и исправьте класс Human так, чтобы логика реализации всех интерфейсов стала корректной.
     * 
     * Шаблоны интерфейсов изменять нельзя.
     */

    public class Human : IWorker, IReader
    {
        public string name;
        public int paperCount;
        public int account = 500;
        public bool isReading = false;
        public bool isAtHome = false;
        public bool isAtWork = false;

        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
        }

        public void BuyPaper(string paper, int price)
        {
            if (price <= account)
            {
                paperCount++;
                account -= price;
                Console.WriteLine($"Круто, свежая газетка... что у нас тут пишут в {paper}");
            }
            else
            {
                DoWork();
                GetPayment(1000);
            }
        }

        public void DoWork()
        {
            this.isAtWork = true;
            Console.WriteLine("Работаю, чтобы заработать много денег!!!");
        }

        public void GetPayment(int count)
        {
            this.account += count;
            Console.WriteLine("Урааа! Сегодня пришла зарплата!!!");
            MoveHome("Пора домой, время хорошенько отдохнуть!", false);
        }

        public void MoveHome(string s, bool emergency)
        {
            isAtHome = true;
            isAtWork = false;
            if (emergency)
            {
                Console.WriteLine("Срочный вызов! Нужно вернуться на работу...");
            }
            else
            {
                Console.WriteLine("По пути домой остановимся, чтобы купить газету!");
            }
        }

        public void ReadNews(string paper)
        {
            isReading = true;
            Console.WriteLine($"Читаю свою любимую газету {paper}");
        }

        public string WriteNews(string body)
        {
            isReading = false;
            Console.WriteLine($"Настало время обновить свою новостную ленту и запостить новости! Напишу новости про {body}!");
            return body;
        }
    }
}
