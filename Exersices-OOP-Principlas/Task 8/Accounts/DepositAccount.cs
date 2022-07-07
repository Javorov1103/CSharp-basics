using System;
using System.Collections.Generic;
using System.Text;
using Task_8.Accounts;
using Task_8.Contracts;

namespace Task_8
{
    class DepositAccount : BankAccount, IInputable,IWithdrawable
    {
        public void Input(decimal amount)
        {
            throw new NotImplementedException();
        }

        public void Withdraw(decimal amount)
        {
            throw new NotImplementedException();
        }

        public override decimal CalculateInterestAmount(int monthCount)
        {
            if(Balance > 0 && Balance < 1000)
            {
                return 0;
            }

            return base.CalculateInterestAmount(monthCount);
        }
    }
}
