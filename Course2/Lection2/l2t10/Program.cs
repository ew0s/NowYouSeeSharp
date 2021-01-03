using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2t10
{
    /*
     * Переопределите для дочерних классов метод GetNewBird() так, чтобы при его вызове у каждого класса
     * возвращались новые экземпляры соответствующих их классов. У утки - утка, у воробья - воробей!
     */

    public class ZooMarket
    {
        public static void Main(string[] args)
        {
            var duck = new Duck().GetNewBird("Donald");
            var sparrow = new Sparrow().GetNewBird("Captain Jack");
            Console.WriteLine(duck.GetType().Name);
            Console.WriteLine(sparrow.GetType().Name);
        }
    }
}
