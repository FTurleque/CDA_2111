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

        public void AccountDebit(double _debit, int _accountNumberClient)
        {
            _accountBalance -= _debit;
        }

        public void AccountCredit(double _credit, int _clientAccountNumber)
        {
            int index = 0;
            
            do
            {

                if (_clientAccount._accountBalance + _credit > _clientAccount._authorizedOverdraft)
                {
                    _clientAccount._accountBalance += _credit;
                }
                else
                {
                    Console.WriteLine($"Vous n'avez pas assez d'argent pour retirer la somme que vous souhaitez.\nVous ne pouvez retirer que {_clientAccount._authorizedOverdraft - _clientAccount._accountBalance}");
                }
            } while (true);
        }
    }
}
