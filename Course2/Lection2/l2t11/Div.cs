using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2t11
{
    class Div : Operation
    {
        public override Double Calculate(int lValue, int rValue)
        {
            try
            {
                return lValue / rValue;
            }
            catch (Exception e)
            {
                if (lValue < 0)
                {
                    return double.NegativeInfinity;
                }
                return Double.PositiveInfinity;
            }
        }
    }
}
