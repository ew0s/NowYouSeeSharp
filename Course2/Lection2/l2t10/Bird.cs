using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2t10
{
    public class Bird
    {
        public virtual Bird GetNewBird(string name)
        {
            return new Bird();
        }
    }
}
