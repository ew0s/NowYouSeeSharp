using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3t4
{
    public interface IFlyable
    {
        void Fly();

        void Fly(Mode mode);
    }
}
