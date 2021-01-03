using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l1t20
{
    public class Bird
    {
        public static int TotalCount { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Weight { get; set; }

        public Bird()
        {
            TotalCount++;
        }
    }
}
