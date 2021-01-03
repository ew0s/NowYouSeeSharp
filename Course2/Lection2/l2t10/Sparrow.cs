using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2t10
{
    public class Sparrow : Bird
    {
        public override Bird GetNewBird(string name)
        {
            return new Sparrow();
        }
    }
}
