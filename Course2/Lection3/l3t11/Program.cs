using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3t11
{
    /*
     * Проанализируйте шаблон и выстройте корректную цепочку наследования. Подумайте как из классов в цепочке наследования является 
     * наиболее абстрактным и сделайте его таковым.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Я не хочу становиться абстрактным...");
        }
    }

    public class Cat : Animal { }
    public class Dog : Animal { }
    public class Animal : LifeForm { }
    public abstract class LifeForm { }
    public class MainCoon : Cat { }
}
