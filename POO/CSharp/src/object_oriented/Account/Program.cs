using System.Collections.Generic;
using System;

namespace Account
{
    class Program
    {
        private static List<Client> clients = new();
        private static List<Account> accountsClients = new();
        private List<int> accountNumber = new();

        static void Main(string[] args)
        {
            Client c1 = new("Fabrice", "Turleque", 30);
            Account c1Account = new(c1, 1, 400);
            accountsClients.Add(c1Account);

            Client c2 = new("Cyril", "Legrand", 35);
            /*List<Account> c2Account = AccountCreation(c2, 300);
            accountsClients.Add(c2Account);*/

            Client c3 = new("Axel", "Bouiller", 18);
            /*List<Account> c3Account = AccountCreation(c3, 100);
            accountsClients.Add(c3Account);*/

            Client c4 = new("Damien", "Simon", 25);
            /*List<Account> c4Account = AccountCreation(c4, 200);
            accountsClients.Add(c4Account);*/

            Client c5 = new("Xavier", "Bardon", 24);
            /*List<Account> c5Account = AccountCreation(c5, 15);
            accountsClients.Add(c5Account);*/

            Client c6 = new("Julien", "Milletre", 26);
            /*List<Account> c6Account = AccountCreation(c6, 30);
            accountsClients.Add(c6Account);

            List<Account> c1Account2 = AccountCreation(c1, 1000);
            accountsClients.Add(c1Account2);*/

            clients.Add(c1);
            clients.Add(c2);
            clients.Add(c3);
            clients.Add(c4);
            clients.Add(c5);
            clients.Add(c6);
            Console.Write(clients);


            Console.ReadKey();
        }
    }
}
