using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Customer
    {
        private int _idCustomer;
        private string _firstName;
        private string _lastName;
        private int _age;

        public int IdCustomer
        {
            get { return _idCustomer; }
            set { _idCustomer = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        //private string phoneNumber;

        /// <summary>
        /// Client constructor
        /// </summary>
        /// <param name="_firstName">First name of the client</param>
        /// <param name="_lastName">Last name of the client</param>
        /// <param name="_age">Age of the client</param>
        public Customer(string _firstName, string _lastName, int _age)
        {
            this._firstName = _firstName;
            this._lastName = _lastName;
            this._age = _age;
        }

        /// <summary>
        /// The client can make a payement
        /// </summary>
        /// <param name="_payment">Payement amount</param>
        /// <param name="_accountNumber">Account to be debited</param>
        /// <param name="bank">Bank where my account is located</param>
        public void MakeAPayment(double _payment, int _accountNumber, ref Bank bank)
        {
            bank.ChooseAccountToDebit(_payment, _accountNumber);
        }

        /// <summary>
        /// The client can make a withdrawal in a bank
        /// </summary>
        /// <param name="_withdrawal">Withdrawal amount</param>
        /// <param name="_accountNumber">Account to be debited</param>
        /// <param name="bank">Bank where my account is located</param>
        public void MakeACashWithdrawal(double _withdrawal, int _accountNumber, ref Bank bank)
        {
            bank.ChooseAccountToDebit(_withdrawal, _accountNumber);
        }

        /// <summary>
        /// The client can make a deposit in his account
        /// </summary>
        /// <param name="_deposit">Deposit amount</param>
        /// <param name="_accountNumber">Account to be credited</param>
        /// <param name="bank">Bank where my account is located</param>
        public void MakeADeposit(double _deposit, int _accountNumber, ref Bank bank)
        {
            bank.ChooseAccountToCredit(_deposit, _accountNumber);
        }
    }
}
