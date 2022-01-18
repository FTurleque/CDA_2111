using System;

namespace TrickDolls
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dolls creation
            Doll doll1 = new("Titi", 2);
            Doll doll2 = new("Tonton", 5);
            Doll doll3 = new("Tata", 7);

            // You cant putt doll3 in doll1 because doll1 is smallest.
            doll3.PlaceDollIn(doll1);

            // Good result to put de dolls in.
            doll1.PlaceDollIn(doll2);
            doll1.Close();
            doll2.PlaceDollIn(doll3);
            doll2.Close();
            doll3.Close();

            // You cant do that because a doll is already there.
            doll2.PlaceDollIn(doll3);

            // Good result to remove the doll.
            doll2.RemoveDollIn(doll3);
            doll3.Close();
            doll1.RemoveDollIn(doll2);
            doll2.Close();
            doll1.Close();
        }
    }
}
