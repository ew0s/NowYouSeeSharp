using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2t1
{
    public class Plane
    {
        public virtual void Fly()
        {
            Console.WriteLine("Я летаю, там летают и все мои потомки...выбора-то у них нету!");
        }
    }
}
