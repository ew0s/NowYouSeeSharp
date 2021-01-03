using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l8t24
{
    public class StringCat
    {
        static int count = 0;

        string name;
        int age;

        public StringCat()
        {
            name = $"Барсик{count}";
            age = count + 1;
        }

        public override string ToString()
        {
            return $"С каждым годом кот по имени {name} становится ещё старше... и сейчас ему уже {age} лет!";
        }
    }
}
