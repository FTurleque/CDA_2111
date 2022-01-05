using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Account
    {
        private int _accountNumber;
        private double _accountBalance;
        private double _authorizedOverdraft;

        public int AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }

        public double AccountBalance
        {
            get { return _accountBalance; }
            set { _accountBalance = value; }
        }

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


        public Account(int _accountNumber, double _accountBalance, double _authorizedOverdraft)
        {
            this._accountNumber = _accountNumber;
            this._authorizedOverdraft = _authorizedOverdraft;
            this._accountBalance = _accountBalance;
        }

        public void Debit(double _debit)
        {
            AccountBalance -= _debit;
        }

        public void Credit(double _credit)
        {
            AccountBalance += _credit;
            
        }
    }
}
