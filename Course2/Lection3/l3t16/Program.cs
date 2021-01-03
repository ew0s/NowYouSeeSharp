using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3t16
{
    /*
     * Добавьте как можно больше интерфейсов к классу Human, так чтобы он не стал абстрактным.
     * Добавлять методы к классу Human нельзя.
     */

    public partial class Program
    {
        public static void Main(string[] args)
        {
            Human human = new Human();
            Console.WriteLine(human);
        }
    }
}
