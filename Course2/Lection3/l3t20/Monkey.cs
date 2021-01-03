using System.Collections.Generic;

namespace l3t20
{
    public class Monkey : AnimalClient
    {
        public Monkey(string fullName, int totalMoneyCount, string accountBankId, bool isAccountBlocked) : base(fullName, totalMoneyCount, accountBankId, isAccountBlocked)
        {
        }

        public override void Pay(int sum)
        {
            if (IsAccountBlocked)
            {
                MagicBank.AllClients.Remove(this.AccountBankId);
                Queue<Check> newQueue = new Queue<Check>();
                var enumerator = MagicBank.AllChecks.GetEnumerator();
                while (enumerator.MoveNext())
                    if (enumerator.Current.clientId != this.AccountBankId)
                        newQueue.Enqueue(enumerator.Current);
                MagicBank.AllChecks = newQueue;
            }
            if (this.TotalMoneyCount < sum)
            {
                this.IsAccountBlocked = true;
                this.RejectPayment();
            }
            this.TotalMoneyCount -= sum;
        }
    }
}
