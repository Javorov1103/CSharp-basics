using System;
using System.Collections.Generic;
using System.Text;
using Task_8.Accounts;
using Task_8.Contracts;

namespace Task_8
{
    class CreditAccount :BankAccount, IInputable
    {
        public void Input(decimal amount)
        {
            Console.WriteLine($"In my accoutn just inputed {amount} lv");
        }

        public override decimal CalculateInterestAmount(int monthCount)
        {
            if(Client.TypeOfClient == "personal")
            {
                monthCount -= 3;
            }
            else if(Client.TypeOfClient == "company")
            {
                monthCount -= 2;
            }

            return base.CalculateInterestAmount(monthCount);
        }
    }
}
