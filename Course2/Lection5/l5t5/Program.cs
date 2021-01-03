using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5t5
{
    /*
     * Измените программу и реализуйте метод PrintName() так, чтобы он выполнялся и для классов Man и Woman. 
     * Реализация метода должна быть только одна и должна выводить в консоль имя принятого экземпляра класса. 
     * Метод Main() изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {
            Human human = new Man();
            Woman woman = new Woman();

            PrintName(human);
            PrintName(woman);
        }

        public static void PrintName(Human man)
        {
            Console.WriteLine(man.Name);
        }
    }
}
