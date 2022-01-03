﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Customer
    {
        private int idCustomer;
        private string firstName;
        private string lastName;
        private int age;
        //private string phoneNumber;

        /// <summary>
        /// Client constructor
        /// </summary>
        /// <param name="_firstName">First name of the client</param>
        /// <param name="_lastName">Last name of the client</param>
        /// <param name="_age">Age of the client</param>
        public Customer(string _firstName, string _lastName, int _age)
        {
            firstName = _firstName;
            lastName = _lastName;
            age = _age;
        }



        /// <summary>
        /// The client can make a payement
        /// </summary>
        /// <param name="message">Name of payement strore</param>
        /// <param name="_payment">Amount of money spent</param>
        public void MakeAPayment(string message, double _payment)
        {
            
        }

        /// <summary>
        /// The client can make a withdrawal in a bank
        /// </summary>
        /// <param name="_withdrawal">Withdrawal amount</param>
        public void MakeACashWithdrawal(double _withdrawal)
        {
            
        }

        /// <summary>
        /// The client can make a deposit in his account
        /// </summary>
        /// <param name="message">Name of the deposit</param>
        /// <param name="_deposit">Deposit amount</param>
        public void MakeADeposit(string message, double _deposit)
        {
            
        }
    }
}