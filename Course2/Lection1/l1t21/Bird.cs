using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l1t21
{
    public class Bird
    {
        internal static int TotalCount { get; private set; }
        internal string Name { get; set; }
        private protected string Description { get; set; }
        private protected int Weight { get; set; }

        public Bird()
        {
            TotalCount++;
        }
    }
}
