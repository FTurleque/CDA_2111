using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Client
    {
        private string firstName;
        private string lastName;
        private string phoneNumber;
        private DateTime birthDate;
        // string street;
        // string streetNumber;
        private int postalCode;
        private string city;
        private int deposit;

        public Client(string _firstName, string _lastName, string _phoneNumber, DateTime _birthDate, int _postalCode, string _city, int _deposit)
        {
            firstName = _firstName;
            lastName = _lastName;
            phoneNumber = _phoneNumber;
            birthDate = _birthDate;
            postalCode = _postalCode;
            city = _city;
            deposit = _deposit;
        }

        private void BorrowABook()
        {

        }

        private void ReturnABook()
        {

        }

    }
}
