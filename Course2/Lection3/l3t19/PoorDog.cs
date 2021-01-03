using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3t19
{
    class PoorDog : Client
    {
        public PoorDog(string name, int accountId) : base(name, accountId)
        {
        }

        public override void Pay(decimal amountOfMoney)
        {
            try
            {
                Validation(AccountId, amountOfMoney);
            }
            catch(ArgumentOutOfRangeException)
            {
            }
        }
    }
}
