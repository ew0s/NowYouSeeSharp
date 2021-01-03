using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3t4
{
    public interface IMovable
    {
        void Move();

        void Move(Mode mode);
    }
}
