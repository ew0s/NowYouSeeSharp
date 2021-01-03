using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l5t6
{
    /*
     * Проанализируйте шаблон. Измените метод HaveFun() так, чтобы он вызвал метод Play() если переданная 
     * персона имеет тип Player, и Dance если он имеет типа Dancer.
     * Шаблон метода Main() изменять нельзя.
     */

    public class Program
    {
        public static void Main(string[] args)
        {

            IPerson person = null;
            string key;
            while (!(key = Console.ReadLine()).Equals("exit"))
            {
                if ("player".Equals(key))
                {
                    person = new Player();
                }
                else if ("dancer".Equals(key))
                {
                    person = new Dancer();
                }
                HaveFun(person);
            }

        }
        public static void HaveFun(IPerson person)
        {
            if (person is Dancer dancer)
            {
                dancer.Dance();
            }
            else if (person is Player player)
            {
                player.Play();
            }
        }
    }
}
