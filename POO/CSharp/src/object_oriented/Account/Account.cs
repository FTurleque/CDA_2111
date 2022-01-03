using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Account
    {
        //private int idAccount;
        public double AccountBalance { get; set; }
        public double AuthorizedOverdraft { get; set; }
        private Customer customer;

        public Account(Customer _customer, double _accountBalance, double _authorizedOverdraft)
        {
            customer = _customer;
            AuthorizedOverdraft = _authorizedOverdraft;
            AccountBalance = _accountBalance;
        }

        public void AccountDebit(double _debit, int _accountNumberClient)
        {
            AccountBalance -= _debit;
        }

        public void AccountCredit(double _credit, int _accountNumberClient)
        {
            AccountBalance += _credit;
        }
    }
}
