using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l1t10
{
    class Mouse
    {
        string name;

        public string Name
        {
            get
            {
                var tmp = name.ToCharArray();
                tmp[0] = char.ToUpper(tmp[0]);
                string output = null;
                foreach (char c in tmp)
                {
                    output += c;
                }
                return output + "!";
            }
        }

        public Mouse(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return $"Я крутая мышка и меня зовут {name}";
        }
    }
}
