using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3t18
{
    /*
     * Проанализируйте код шаблона. Сейчас наследственные связи расставлены таким образом, что логика
     * наследования не сохраняется. Внесите изменения таким образом, чтобы логика связи объектов стала
     * корректной, а код остался валидным. 
     * После рефакторинга неиспользуемые элементы следует удалить.
     */

    public class AutoClub
    {
        public static void Main(string[] args)
        {
            new Bus().Move("ангар!");
            new Train().Move("там, куда маглам не попасть!");
            new Plane().Move("на тусовку для самолётов!");
        }
    }

    public abstract class Car
    {
        public abstract void Move(string direction);
    }

    public class Bus : Car
    {
        public override void Move(string direction)
        {
            Console.WriteLine("Автобус едет в " + direction);
        }
    }

    public class Train
    {
        public void Move(string direction)
        {
            Console.WriteLine("Поезд едет прямиком в Хогвартс, который находится " + direction);
        }
    }

    public class Plane
    {
        public void Move(string direction)
        {
            Console.WriteLine("Самолёт катится в ангар... или " + direction);
        }
    }
}
