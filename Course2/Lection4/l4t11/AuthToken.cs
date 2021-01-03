using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l4t11
{
    [AttributeUsage(AttributeTargets.Method)]
    public class AuthToken : Attribute
    {
        private static List<string> tokens = new List<string>();

        public AuthToken(string[] strings)
        {
            foreach (var s in strings)
            {
                if (!tokens.Contains(s))
                {
                    tokens.Add(s);
                }
            }
        }

        public bool Check(CoolCat coolCat)
        {
            return tokens.Contains(coolCat.token);
        }
    }
}
