using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Bank
    {
        private List<Customer> _customers = new();
        private List<int> _accounts = new();
        private Dictionary<Customer, List<Account>> _associationCustomersAccounts = new();

        public Dictionary<Customer, List<Account>> AssociationCustomersAccounts
        {
            get { return _associationCustomersAccounts; }
        }

        public Bank()
        {

        }

        public void AddClient(Customer _customer, Account _account)
        {
            Customer customerInfo = _customer;
            _customers.Add(customerInfo);
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
            _associationCustomersAccounts.Add(_customer, listTmpAccount);
        }

        public void FindAccount()
        {

        }

        /*public override string ToString()
        {
            StringBuilder tmp = new();
            tmp.Append($"Votre prénom est : {}");
            return base.ToString();
        }*/

        /*private Account AccountCreation(Client _client, double _accountNB)
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
        }
        */

        public int GetAccountNumber()
        {
            int accountNumber;
            do
            {
                accountNumber = RandomNumber(1, 5);
            } while (_accounts.Contains(accountNumber));
            _accounts.Add(accountNumber);
            return accountNumber;
        }

        private int RandomNumber(int start, int end)
        {
            Random number = new Random();
            return number.Next(start, end);
        }
    }
}
