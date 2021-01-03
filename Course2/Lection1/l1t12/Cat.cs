using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l1t12
{
    public class Cat
    {
        int Age { get; set; }
        string Name { get; set; }

        public Cat(int age, string name)
        {
            Program.CatCount++;
            Age = age;
            Name = name;
        }
    }
}
