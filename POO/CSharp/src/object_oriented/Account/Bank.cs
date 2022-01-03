using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Bank
    {
        private static List<Customer> customers = new();
        private static List<Account> accountsCustomers = new();

        /// <summary>
        /// Bank constructor
        /// </summary>
/*        private void MakeCustomersAccounts(Client client, List<Account> accounts)
        {
            accountsClients = new();
            for (int i = 0; i < 3; i++)
            {
                List<Ob> data = new();
                accountsClients.Add(client);


            }
        }
*/
        public static void AddClient(Customer _customer, Account _account)
        {
            Customer customerInfo = _customer;
            customers.Add(customerInfo);
            AddAccountToCustomer(_customer, _account);
        }

        public static void AddAccountToCustomer(Customer _customer, Account _account)
        {
            double accountBalance = _account.AccountBalance;
            double authorizedOverdraft = _account.AuthorizedOverdraft;
            Account account = new(_customer, accountBalance, authorizedOverdraft);
            accountsCustomers.Add(account);
        }


        /*private List<Account> AccountCreation(Customer _client, double _accountNB)
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

        private int RandomNumber(int start, int end)
        {
            Random number = new Random();
            return number.Next(start, end);
        }

        public List<List<Account>> AccountsClients()
        {
            return accounts;
        }*/
    }
}
