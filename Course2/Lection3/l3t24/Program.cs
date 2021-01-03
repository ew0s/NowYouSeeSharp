using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3t24
{
    /*
     * Для класса Duck добавьте метод Say() который ничего не принимает и не возвращает, но 
     * выводит в консоль текущую дату в формате "день(2 цифры) месяц(русский язык) год(4 цифры)".
     * 
     * Класс Duck должен сохранить поддержку интерфейса ISayable, а сам интерфейс изменять нельзя.
     */

    public class Duck : ISayable
    {
        public static void Main(string[] args)
        {
            /* Добавьте свой код ниже */
            Duck duck = new Duck();
            ISayable sayable = new Duck();
            sayable.Say();
        }

        public void Say()
        {
            Console.WriteLine(DateTime.Now.ToString("dd MMMM yyyy", new CultureInfo("ru-RU")));
        }

        /* Добавьте свой код ниже */
        void ISayable.Say()
        {
            Console.WriteLine("Кря-кря");
        }
    }
}
