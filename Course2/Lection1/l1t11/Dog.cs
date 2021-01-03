using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l1t11
{
    public class Dog
    {
        private static Program program = new Program();
        private string name;
        private int age;

        public Dog(string name, int age)
        {
            this.name = name;
            this.age = age;
            program.ToDogList(this);
        }

        public override string ToString()
        {
            return $"Меня зовут {name}";
        }
    }
}
