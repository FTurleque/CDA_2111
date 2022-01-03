using System.Collections.Generic;
using System;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new("Fabrice", "Turleque", 30);
            Account c1Account = new(c1, 30000, -400);
            Bank.AddClient(c1, c1Account);

            Customer c2 = new("Cyril", "Legrand", 35);
            Account c2Account = new(c2, 2000, -300);
            Bank.AddClient(c2, c2Account);

            Customer c3 = new("Axel", "Bouiller", 18);
            Account c3Account = new(c3, 500, -100);
            Bank.AddClient(c3, c3Account);

            Customer c4 = new("Damien", "Simon", 25);
            Account c4Account = new(c4, 1800, 200);
            Bank.AddClient(c4, c4Account);

            
        }
    }
}
