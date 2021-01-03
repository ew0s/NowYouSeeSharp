using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2t24
{
    public class Dog
    {
        public static object operator /(Dog lValueDog, int rValueInt)
        {
            if (rValueInt == 0)
            {
                return new Cat();
            }

            return 7;
        }
    }
}
