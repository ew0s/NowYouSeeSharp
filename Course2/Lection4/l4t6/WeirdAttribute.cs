using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l4t6
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Delegate)]
    public class WeirdAttribute : Attribute
    {

    }
}
