using System;
using System.Reflection;
using Task_8.Accounts;
using Task_8.Clients;
using Task_8.Factories;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccountFactory bankAccountFactory = new BankAccountFactory();

            var depostAcount = bankAccountFactory.CreateBankAccount("DepositAccount");
        }
    }
}
