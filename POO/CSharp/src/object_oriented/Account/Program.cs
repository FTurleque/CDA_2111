using System.Collections.Generic;
using System;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new();

            Customer c1 = new("Fabrice", "Turleque", 30);
            int c1AcountNumber = bank.GetAccountNumber();
            Account c1Account = new(c1AcountNumber, 30000, -400);
            bank.AddClient(c1, c1Account);


            Customer c2 = new("Cyril", "Legrand", 35);
            int c2AcountNumber = bank.GetAccountNumber();
            Account c2Account = new(c2AcountNumber, 2000, -300);
            bank.AddClient(c2, c2Account);

            Customer c3 = new("Axel", "Bouiller", 18);
            int c3AcountNumber = bank.GetAccountNumber();
            Account c3Account = new(c3AcountNumber, 500, -100);
            bank.AddClient(c3, c3Account);

            Customer c4 = new("Damien", "Simon", 25);
            int c4AcountNumber = bank.GetAccountNumber();
            Account c4Account = new(c4AcountNumber, 1900, -1200);
            bank.AddClient(c4, c4Account);

            c4Account.AccountCredit(100, c4AcountNumber);
        }
    }
}
