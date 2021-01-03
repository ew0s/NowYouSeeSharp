using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l3t19
{
    public abstract class Client : IPayable
    {
        public string Name { get; set; }
        public int AccountId { get; set; }
        private decimal TotalMoney { get; set; }

        public Client()
        {}

        public Client(string name, int accountId)
        {
            Name = name;
            AccountId = accountId;
        }

        public void PaymentRejected()
        {
            throw new ArgumentOutOfRangeException();
        }

        public void Validation(int id, decimal amountOfMoneyToDrop)
        {
            if (AccountId != id || TotalMoney < amountOfMoneyToDrop)
            {
                PaymentRejected();
            }

            TotalMoney -= amountOfMoneyToDrop;
        }
        public abstract void Pay(decimal amountOfMoney);
    }
}
