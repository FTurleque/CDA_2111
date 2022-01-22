using System;

namespace PeopleWithWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime _time = DateTime.Now;

            // Make people
            Person p1 = new("Fabrice", "Turleque");
            Person p2 = new("Paul", "Bourgeois");
            Person p3 = new("Cyril", "Legrand");
            Person p4 = new("Toto", "Dupuis");

            // Make a watch and use it.
            Watch watch1 = new(_time);
            Console.WriteLine($"First watch : {watch1.Time.ToString("t")}.");
            Watch copyWatch1 = new(watch1);
            Console.WriteLine($"Copy watch : {copyWatch1.Time:t}.\n");

            // Advance the time of the watches but its initialization is done automatically now.
            // so it will return to the origin if you ask for the time again.
            // you need to redefine the hour and the minute.
            Console.WriteLine($"Advanced 30 minutes first watch : {watch1.AdvanceTheTime(30)}.");
            Console.WriteLine($"Advanced 120 minutes copy watch : {copyWatch1.AdvanceTheTime(120)}.");
            Console.WriteLine($"Copy watch whitout redefine the time : {copyWatch1.Time:t}.\n");

            p1.AddWatch(watch1);
            // If you redefine the time in two variables.
            Console.WriteLine($"First watch with time a redefinition in 2 variables : {p1.GivingTheHourWithRedefine()}.\n");

            Watch watch2 = new(15, 3);
            p2.AddWatch(watch2);
            Console.WriteLine($"The owner of the watch 2 is {p2.FirstName} {p2.LastName} and is {p2.GivingTheActualyHour()}.");
            p2.GiveAWatch(p4);
            Console.WriteLine(p4.GivingTheActualyHour());
            p4.GiveAWatch(p2);
            Console.WriteLine($"{p2.FirstName} {p2.LastName} giving his watch to {p4.FirstName} {p4.LastName}.\n{p2.GivingTheActualyHour()}");
            Console.WriteLine($"The owner of the watch 2 is {p4.FirstName} {p4.LastName} now and is {p4.GivingTheActualyHour()}.\n");

            Watch copyWatch2 = new(watch2);
            p3.AddWatch(copyWatch2);
            Console.WriteLine($"The owner of the copy watch 2 is {p3.FirstName} {p3.LastName} and is {p3.GivingTheActualyHour()}");
            p3.AdvanceTheTimeOnYourWatch(15);
            Console.WriteLine($"Advanced 15 minutes copy watch 2 and is {p3.GivingTheHourWithRedefine()} now.");

            // Impossible creation.
            Watch watchImpossible1 = new(24, 50);
            Watch watchImpossible2 = new(13, 100);
        }
    }
}
