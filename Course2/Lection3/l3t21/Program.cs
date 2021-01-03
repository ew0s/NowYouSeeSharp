using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3t21
{
    /*
     * Сделайте так, чтобы класс Program стал реализовывать все интерфейсы в программе, при этом
     * изменять наследственные связи класса Program нельзя.
     */

    public class Program : ISwimmable
    {
        public static void Main(string[] args)
        {
        }

        public void Swim(string direction)
        {
            Console.WriteLine("Плавать хорошо! Особенно " + direction);
        }

        public void Swim()
        {
            Console.WriteLine("Плавать хорошо!");
        }

        
    }
}
