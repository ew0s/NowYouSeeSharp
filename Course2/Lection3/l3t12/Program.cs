using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3t12
{
    /*
     * Добавьте абстрактному классу Car 4 произвольных метода, при этом только двум из них задайте реализацию по умолчанию.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            
        }
    }

    public abstract class Car
    {
        /* Добавьте свой код ниже */
        public abstract void One();
        public abstract void Two();

        public void Three(int a)
        {
            Console.WriteLine("d");
        }

        public void Four(int a)
        {
            Console.WriteLine("d");
        }

    }
}
