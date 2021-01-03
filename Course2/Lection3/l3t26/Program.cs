using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3t26
{
    /*
     * Реализуйте оба интерфейса для класса Captain таким образом, чтобы все методы интерфейсов 
     * должны выбрасывать исключения, указывающие на отсутствие реализации данных методов.
     * 
     * Класс Captain должен содержать 5 методов.
     */

    public class Captain : ISwimmable, IShipControl
    {
        public void Smoke(int time)
        {
            throw new NotImplementedException();
        }

        public void TeamManage()
        {
            throw new NotImplementedException();
        }

        public void Swim(string direction)
        {
            throw new NotImplementedException();
        }

        public void ChangeDirection()
        {
            throw new NotImplementedException();
        }

        public void Rest(int time)
        {
            throw new NotImplementedException();
        }
    }
}
