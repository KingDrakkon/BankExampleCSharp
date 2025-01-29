using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class PremiumOverdraftCheckingAccount : CheckingsAccount
    {
        public decimal CashbackRate { get; private set; }
        public PremiumOverdraftCheckingAccount(string accountNumber, string accountHolder, decimal initialBalance, decimal overdraftlimit, decimal cashbackRate):
            base(accountNumber, accountHolder, initialBalance, overdraftlimit)
        {
            CashbackRate = cashbackRate;
        }

        public void ApplyCashback(decimal purchaseAmount)
        {
            if (purchaseAmount <= 0) throw new ArgumentException("Purchase amount must be greater than 0");
            var cashback = purchaseAmount * CashbackRate;
            this.Deposit(cashback);
        }
    }
}
