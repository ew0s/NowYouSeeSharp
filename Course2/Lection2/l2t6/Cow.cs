using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2t6
{
    class Cow : Cat
    {
        public override void Say()
        {
            Console.WriteLine("Я - корова, но внутри я тоже котик!");
        }
    }
}
