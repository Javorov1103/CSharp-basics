using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Task_8.Accounts;
using Task_8.Contracts;

namespace Task_8.Factories
{
   public class BankAccountFactory
    {
        Dictionary<string, Type> bankAccounts;

        public BankAccountFactory()
        {
            LoadTypesICanReturn();
        }
        public IBankAccount CreateBankAccount(string bankAccountType)
        {
            Type t = GetTypeToCreate(bankAccountType);

            if (t == null) throw new Exception("Bad Type");

            else return Activator.CreateInstance(t) as IBankAccount;
        }

        private Type GetTypeToCreate(string bankAccountType)
        {
            foreach (var bankAccount in bankAccounts)
            {
                if (bankAccount.Key.Contains(bankAccountType.ToLower()))
                {
                    return bankAccounts[bankAccount.Key];
                }
            }
            return null;
        }

        private void LoadTypesICanReturn()
        {
            bankAccounts = new Dictionary<string, Type>();
            Type[] typeInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();

            foreach (Type type in typeInThisAssembly)
            {
                if (type.GetInterface(typeof(IBankAccount).ToString()) != null)
                {
                    bankAccounts.Add(type.Name.ToLower(), type);
                }
            }
        }
    }
}
