using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace l6t17
{
    /*
     * Внутри класса Program создайте публичные статические методы:
     *      1) GetKitty() выводит в консоль фразу "Хочу купить котёнка!", после вызывает метод
     *         Open() в отдельном потоке.
     *      2) Open() выводит в консоль фразу "Открываю свой любимый браузер", после вызывает
     *         метод Search() в отдельном потоке.
     *      3) Search() выводит в консоль фразу "Вбиваю в поисковую строку фразу: "Купить котёнка Main Coon", 
     *         после вызывает метод Show() в отдельном потоке.
     *      4) Show() выводит в консоль фразу "Смотрю подходящее мне объявление", после вызывает
     *         метод Call() в отдельном потоке.
     *      5) Call() выводит в консоль фразу "Звоню и договариваюсь о покупке", после вызывает метод 
     *         Buy() в отдельном потоке.
     *      6) Buy() выводит в консоль фразу "Покупаю своего котёнка", после вызывает метод HappyEnd() 
     *         в отдельном потоке.
     *      7) HappyEnd() выводит в консоль фразу "Теперь у меня есть котёнок, назову-ка я его Тишка!"
     * Внутри метода Main() вызовите метод GetKitty() и сделайте так, чтобы в консоль была выведена полная 
     * история покупки котёнка в соответствии с логикой повествования.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            GetKitty();
        }

        public static void GetKitty()
        {
            Console.WriteLine("Хочу купить котёнка!");
            Thread thread = new Thread(Open); 
            thread.Start();
            thread.Join();
        }

        public static void Open()
        {
            Console.WriteLine("Открываю свой любимый браузер");
            Thread thread = new Thread(Search);
            thread.Start();
            thread.Join();
        }

        public static void Search()
        {
            Console.WriteLine("Вбиваю в поисковую строку фразу: \"Купить котёнка Main Coon\"");
            Thread thread = new Thread(Show);
            thread.Start();
            thread.Join();
        }

        public static void Show()
        {
            Console.WriteLine("Смотрю подходящее мне объявление");
            Thread thread = new Thread(Call);
            thread.Start();
            thread.Join();
        }

        public static void Call()
        {
            Console.WriteLine("Звоню и договариваюсь о покупке");
            Thread thread = new Thread(Buy);
            thread.Start();
            thread.Join();
        }

        public static void Buy()
        {
            Console.WriteLine("Покупаю своего котёнка");
            Thread thread = new Thread(HappyEnd);
            thread.Start();
            thread.Join();
        }

        public static void HappyEnd()
        {
            Console.WriteLine("Теперь у меня есть котёнок, назову-ка я его Тишка!");
        }
    }
}
