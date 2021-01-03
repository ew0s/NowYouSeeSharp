using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l1t12
{
    public class Mouse
    {
        int Age { get; set; }
        string Name { get; set; }

        public Mouse(int age, string name)
        {
            Program.MouseCount++;
            Age = age;
            Name = name;
        }
    }
}
