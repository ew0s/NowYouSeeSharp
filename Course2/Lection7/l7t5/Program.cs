using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace l7t5
{
    /*
     * Создайте два публичных класса Cat и Mouse - наследников абстрактного класса Animal.
     * Для каждого из созданных классов:
     *      1) Создайте конструктор, который принимает строку и список строк в качестве входящих параметров
     *         и устанавливает значения соответствующим полям класса. 
     *      2) Реализуйте метод Play() таким образом, чтобы экземпляр 1 раз в полсекунды делал ход, удаляя последнее
     *         действие из списка доступных.
     *      3) Как только доступных ходов не останется - метод вывести в консоль фразу "У ХХХ ходов больше нет!", 
     *         где ХХХ - значение имени текущего экземпляра класса, после чего должен аварийно прерывать свой текущий поток.
     * Внутри класса Program создайте 2 публичных статических списка строк: catMove, mouseMove, в них будут подаваться
     * произвольные коллекции с доступными действиями.
     * Внутри метода Main() создайте по 1 экземпляру класса Cat и Mouse, назвав кота - Том, а мышь - Джерри, а также
     * передав им соответствующие статические элементы, необходимые для инициализации.
     * Внутри метода Main() запустите в отдельных потоках метод Play() для экземпляров созданных классов.
     * Метод Main() должен определять победителя и выводить в консоль сведения о нём в формате: 
     * "Победитель: ХХХ!!!", где ХХХ - значение имени экземпляра победителя. Побеждает тот, чей ход был последним!
     * Шаблон класса Animal изменять нельзя.
     */

    public class Program
    {
        public static string winnerName = "";
        public static List<string> catMove = new List<string>();
        public static List<string> mouseMove = new List<string>();
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            catMove = new List<string>
            {
                "C",
            };

            mouseMove = new List<string>
            {
                "M",
                "M",
                "M",
                "M",
            };

            var cat = new Cat("Том", catMove);
            var mouse = new Mouse("Джерри", mouseMove);

            var thread1 = new Thread(cat.Play);
            var thread2 = new Thread(mouse.Play);

            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();
            Console.WriteLine($"Победитель: {winnerName}!!!");
        }
    }
}
