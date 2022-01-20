using System;

namespace PeopleWithWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime _time = DateTime.Now;

            // Make a watch and use it.
            Watch watch1 = new(_time);
            Console.WriteLine($"First watch {watch1.Time.ToString("t")}.");
            Watch copyWatch1 = new(watch1);
            Console.WriteLine($"\nCopy watch {copyWatch1.Time:t}.");

            // Advance the time of the watches but its initialization is done automatically.
            // so it will return to the origin if you ask for the time again.
            Console.WriteLine($"First watch {watch1.AdvanceTheTime(30)}.");
            Console.WriteLine($"Copy watch {copyWatch1.AdvanceTheTime(120)}.");

            Person p1 = new("Fabrice", "Turleque");

            p1.AddWatch(watch1);
            Console.WriteLine($"First watch {p1.GivingTheTime()}.");

            Person p2 = new("Paul", "Bourgeois");
            Person p3 = new("Cyril", "Legrand");
            Person p4 = new("Toto", "Dupuis");

            Watch watch2 = new(15, 3);

            // Impossible creation.
            Watch watchImpossible1 = new(24, 50);
            Watch watchImpossible2 = new(13, 100);
        }
    }
}
