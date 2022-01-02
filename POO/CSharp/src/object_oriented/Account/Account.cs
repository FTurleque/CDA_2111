using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Account
    {
        private Client client;
        private int accountNumber;
        private double accountBalance;

        public Account(Client _client, int _accountNumber, double _accountBalance)
        {
            client = _client;
            accountNumber = _accountNumber;
            accountBalance = _accountBalance;
        }

        public void AccountDebit(double _debit, int _accountNumberClient)
        {
            accountBalance -= _debit;
        }

        public void AccountCredit(double _credit, int _accountNumberClient)
        {
            accountBalance += _credit;
        }
    }
}
