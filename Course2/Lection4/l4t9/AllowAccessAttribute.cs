using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l4t9
{
    [AttributeUsage(AttributeTargets.Class)]
    public class AllowAccessAttribute : Attribute
    {
        public bool IsAllow { get; }

        public AllowAccessAttribute(bool isAllow)
        {
            IsAllow = isAllow;
        }
    }
}
