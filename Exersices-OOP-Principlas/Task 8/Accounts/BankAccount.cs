using System;
using System.Collections.Generic;
using System.Text;
using Task_8.Clients;

namespace Task_8.Accounts
{
    public abstract class BankAccount
    {
        private Client client;
        private decimal balance;
        private double interest;

        public Client Client
        {
            get { return client; }
            set { client = value; }
        }
        public double Interest
        {
            get { return interest; }
            set { interest = value; }
        }

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public virtual decimal CalculateInterestAmount(int monthCount)
        {
            return Balance * (decimal)Interest * monthCount;
        }

    }
}
