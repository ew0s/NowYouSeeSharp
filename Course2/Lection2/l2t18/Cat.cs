using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2t18
{
    class Cat : Animal
    {
        public override void SayMeow(int number)
        {
            Console.Write("М");
            for (int i = 0; i < number; i++)
            {
                Console.Write("я");
            }

            Console.WriteLine("у");
        }
    }
}
