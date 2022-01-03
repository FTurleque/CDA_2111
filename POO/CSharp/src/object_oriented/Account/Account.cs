using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Account
    {
        private double _accountBalance;

        public double AccountBalance
        {
            get { return _accountBalance; }
            set { _accountBalance = value; }
        }

        private double _authorizedOverdraft;

        public double AuthorizedOverdraft
        {
            get { return _authorizedOverdraft; }
            set { _authorizedOverdraft = value; }
        }


        // With propfull
        /*private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }*/


        public Account(double _accountBalance, double _authorizedOverdraft)
        {
            this._authorizedOverdraft = _authorizedOverdraft;
            this._accountBalance = _accountBalance;
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
