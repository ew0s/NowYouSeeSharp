using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2t11
{
    class Sub : Operation
    {
        public override double Calculate(int lValue, int rValue)
        {
            return lValue - rValue;
        }
    }
}
