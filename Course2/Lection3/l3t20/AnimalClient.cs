using System;

namespace l3t20
{
    public abstract class AnimalClient : IPayable
    {
        public string FullName { get; set; }
        public int TotalMoneyCount { get; set; }
        public string AccountBankId { get; set; }
        public bool IsAccountBlocked { get; set; } = false;

        public AnimalClient(string fullName, int totalMoneyCount, string accountBankId, bool isAccountBlocked)
        {
            FullName = fullName;
            TotalMoneyCount = totalMoneyCount;
            AccountBankId = accountBankId;
            IsAccountBlocked = isAccountBlocked;
        }

        public void RejectPayment()
        {
            throw new InvalidOperationException();
        }

        public abstract void Pay(int sum);
    }


}
