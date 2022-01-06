using System.Collections.Generic;
using System;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new();

            List<Account> c1Accounts = new();
            Customer c1 = new("Fabrice", "Turleque", 30);
            int c1AcountNumber = bank.GetAccountNumber();
            Account c1Account = new(c1AcountNumber, 30000, -400);
            c1Accounts.Add(c1Account);
            bank.AssociateClientWithAccount(c1, c1Accounts);
            Console.WriteLine(Display(c1, c1Account));

            c1.MakeAPayment(20000, c1AcountNumber, ref bank);

            Console.WriteLine(Display(c1, c1Account));

            c1.MakeADeposit(500, c1AcountNumber, ref bank);

            Console.WriteLine(Display(c1, c1Account));

            /*List<Account> c2Accounts = new();
            Customer c2 = new("Cyril", "Legrand", 35);
            int c2AcountNumber = bank.GetAccountNumber();
            Account c2Account = new(c2AcountNumber, 2000, -300);
            c2Accounts.Add(c2Account);
            bank.AssociateClientWithAccount(c2, c2Accounts);*/

            List<Account> c3Accounts = new();
            Customer c3 = new("Axel", "Bouiller", 18);
            int c3AccountNumber = bank.GetAccountNumber();
            Account c3Account = new(c3AccountNumber, 500, -100);
            c3Accounts.Add(c3Account);
            bank.AssociateClientWithAccount(c3, c3Accounts);

            Console.WriteLine(Display(c3, c3Account));

            c3.MakeACashWithdrawal(650, c3AccountNumber, ref bank);

            Console.WriteLine(Display(c3, c3Account));


            List<Account> c4Accounts = new();
            Customer c4 = new("Damien", "Simon", 25);
            int c4AcountNumber = bank.GetAccountNumber();
            Account c4Account = new(c4AcountNumber, 1900, -1200);
            c4Accounts.Add(c4Account);
            bank.AssociateClientWithAccount(c4, c4Accounts);

            c4.MakeAPayment(100, c4AcountNumber, ref bank);
            Console.WriteLine(Display(c4, c4Account));

        }

        public static string Display(Customer customer, Account account) 
        {
            return $"{customer.LastName} {customer.FirstName} Votre compte est a {account.AccountBalance} et vous avez droit à un découvert de {account.AuthorizedOverdraft} !";
        }
    }
}
