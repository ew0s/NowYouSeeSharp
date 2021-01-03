using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3t6.Interfaces
{
    public interface IStorable
    { 
        void StoreItem(string item);
        void MoveToAnotherStorage(string item, string storage);
        int CurrentCountInStorage(string item);
    }
}
