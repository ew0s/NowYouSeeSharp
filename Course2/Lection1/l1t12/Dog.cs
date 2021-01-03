using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l1t12
{
    public class Dog
    {
        int Age { get; set; }
        string Name { get; set; }

        public Dog(int age, string name)
        {
            Program.DogCount++;
            Age = age;
            Name = name;
        }
    }
}
