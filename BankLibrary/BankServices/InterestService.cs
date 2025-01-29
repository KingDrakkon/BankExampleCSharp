using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankLibrary;

namespace BankServices
{
    public class InterestService
    {
        public void ApplyInterestToAccounts(List<Account> accounts)
        {
            foreach (var account in accounts)
            {
                if (account is SavingsAccount savingsAccount)
                {
                    savingsAccount.applyInterest();
                    Console.WriteLine($"Interest applied to SavingsAccount({savingsAccount.AccountNumber}) New Balance {savingsAccount.Balance:C}");
                }

                if(account is HighInterestSavingsAccount highInterestSavingsAccount)
                {
                    highInterestSavingsAccount.applyInterest();
                    highInterestSavingsAccount.ApplyBonusInterest(0.01m);
                    Console.WriteLine($"Bonus Interest applied to HighInterestSavingsAccount({highInterestSavingsAccount.AccountNumber}) New Balance {highInterestSavingsAccount.Balance:C}");
                }
            }
        }
    }
}
