using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Bank
    {
        private List<Customer> customers = new();
        private List<Account> accounts = new();
        private Dictionary<Customer, List<Account>> associationCustomersAccounts = new();

        public Bank()
        {

        }

        public int GetAccountNumber(int _accountNumber = 0000)
        {
            _accountNumber++;
            return _accountNumber;
        }

        public void AddClient(Customer _customer, Account _account)
        {
            Customer customerInfo = _customer;
            customers.Add(customerInfo);
            AddAccountToCustomer(_customer, _account);
        }

        public void AddAccountToCustomer(Customer _customer, Account _account)
        {
            int accountNumber = _account.AccountNumber;
            double accountBalance = _account.AccountBalance;
            double authorizedOverdraft = _account.AuthorizedOverdraft;
            Account account = new(accountNumber, accountBalance, authorizedOverdraft);
            List<Account> listTmpAccount = new();
            listTmpAccount.Add(account);
            accounts.Add(account);
            associationCustomersAccounts.Add(_customer, listTmpAccount);
        }

        /*private void AccountCreation(Customer _client, double _accountNB)
        {
            List<Account> accounts = new();
            int accountID;
            do
            {
                accountID = RandomNumber(1, 20);
            } while (accountNumber.Contains(accountID));
            accountNumber.Add(accountID);
            Account accountClient = new(_client, accountID, _accountNB);
            accounts.Add(accountClient);
            return accounts;
        }*/
    }
}
