using System;
using System.Collections.Generic;
using System.Text;
using Task_8.Accounts;
using Task_8.Contracts;

namespace Task_8
{
    class MorgageAccount : BankAccount, IInputable
    {
        public void Input()
        {
            throw new NotImplementedException();
        }

        public override decimal CalculateInterestAmount(int monthCount)
        {
            if (Client.TypeOfClient == "personal")
            {
                monthCount -= 6;
                if(monthCount < 0)
                {
                    monthCount = 0;
                }
                return base.CalculateInterestAmount(monthCount);
            }
            else if (Client.TypeOfClient == "company")
            {
                double halfInterest = Interest / 2;
                decimal interestAmount = 0.0m;

                if (monthCount > 12)
                {
                    interestAmount += Balance * (decimal)halfInterest * 12;
                    interestAmount += Balance * (decimal)Interest * (monthCount - 12);
                } 
                else if(monthCount <= 12)
                {
                    interestAmount += Balance * (decimal)halfInterest * monthCount;
                }

                return interestAmount;
            }

            return 0;
        }
    }
}
