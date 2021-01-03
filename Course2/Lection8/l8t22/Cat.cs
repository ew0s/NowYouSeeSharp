using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l8t22
{
    public class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }

        public Cat(string name, int age, int weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"{Name}&&{Age}&&{Weight}";
        }
    }
}
