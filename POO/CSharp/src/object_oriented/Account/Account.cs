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

        /// <summary>
        /// Account builder
        /// </summary>
        /// <param name="_accountNumber">Account number</param>
        /// <param name="_accountBalance">Account balance</param>
        /// <param name="_authorizedOverdraft">If the client can be overdrawn</param>
        public Account(int _accountNumber, double _accountBalance, double _authorizedOverdraft)
        {
            this._accountNumber = _accountNumber;
            this._authorizedOverdraft = _authorizedOverdraft;
            this._accountBalance = _accountBalance;
        }

        /// <summary>
        /// Make a debit to the account
        /// </summary>
        /// <param name="_debit">Debit amount</param>
        /// <param name="_account">Information on the account to make a debit</param>
        public void Debit(double _debit, Account _account)
        {
            if (_account.AccountBalance - _debit > _account.AuthorizedOverdraft)
            {
                _account.AccountBalance -= _debit;
            }
            else
            {
                Console.WriteLine("Vous n'avez pas assez d'argent pour retirer la somme voulut !");
            }
        }

        /// <summary>
        /// Make a credit to the account
        /// </summary>
        /// <param name="_credit">Credit amount</param>
        /// <param name="_account">Information on the account to make a credit</param>
        public void Credit(double _credit, Account _account)
        {
            _account.AccountBalance += _credit;
            
        }
    }
}
