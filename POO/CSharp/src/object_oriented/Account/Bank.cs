using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Bank
    {
        private readonly List<int> _accounts = new();
        private readonly Dictionary<Customer, List<Account>> _associationCustomersAccounts = new();

        public Bank()
        {

        }

        /// <summary>
        /// Associate account and client in dictionnary
        /// </summary>
        /// <param name="_customer">Information client</param>
        /// <param name="_account">Information on the account Client</param>
        public void AssociateClientWithAccount(Customer _customer, List<Account> _account)
        {
            _associationCustomersAccounts.Add(_customer, _account);
        }

        /// <summary>
        /// I retrieve the customer's account information to make a debit. 
        /// </summary>
        /// <param name="_debit">Debit amount</param>
        /// <param name="_accountNumber">Client account number</param>
        public void ChooseAccountToDebit(double _debit, int _accountNumber)
        {
            foreach (KeyValuePair< Customer, List<Account>> tmp in _associationCustomersAccounts)
            {
                var x = tmp.Value;
                for (int i = 0; i < x.Count; i++)
                {
                    if (x[i].AccountNumber == _accountNumber)
                    {
                        x[i].Debit(_debit, x[i]);
                    }
                }
            }
        }

        /// <summary>
        /// I retrieve the customer's account information to make a credit. 
        /// </summary>
        /// <param name="_credit">Crediut amount</param>
        /// <param name="_accountNumber">Client account number</param>
        public void ChooseAccountToCredit(double _credit, int _accountNumber)
        {
            foreach (KeyValuePair<Customer, List<Account>> tmp in _associationCustomersAccounts)
            {
                var x = tmp.Value;
                for (int i = 0; i < x.Count; i++)
                {
                    if (x[i].AccountNumber == _accountNumber)
                    {
                        x[i].Credit(_credit, x[i]);
                    }
                }
            }
        }

        /// <summary>
        /// Generate the customer's account number 
        /// </summary>
        /// <returns>I return the customer's account number</returns>
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

        /// <summary>
        /// I generate a random number between two values
        /// </summary>
        /// <param name="start">Start value</param>
        /// <param name="end">End value</param>
        /// <returns>I return a random number</returns>
        private int RandomNumber(int start, int end)
        {
            Random number = new Random();
            return number.Next(start, end);
        }

    }
}
