using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3t6.Interfaces
{
    public interface IUsable
    {
        bool UseItem(string item);
        bool PickUpItem(string item);
        void DropItem(string item);
    }
}
