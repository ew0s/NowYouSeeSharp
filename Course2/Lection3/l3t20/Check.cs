using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3t20
{
    public class Check
    {
        public string clientId;
        public int total;

        public Check(string clientId, int total)
        {
            this.clientId = clientId;
            this.total = total;
        }
    }
}
