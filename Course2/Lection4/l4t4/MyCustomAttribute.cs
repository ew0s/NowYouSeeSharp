using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Console = System.Console;

namespace l4t4
{
    public class MyCustomAttribute : Attribute
    {
        public MyCustomAttribute(int number)
        {
            Console.WriteLine(number);
        }

        public MyCustomAttribute(bool boolean)
        {
            Console.WriteLine(boolean);
        }

        public MyCustomAttribute(string message)
        {
            Console.WriteLine(message);
        }
    }
}
