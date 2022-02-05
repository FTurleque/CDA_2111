﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleWithWatch
{
    class Person
    {
        private string _firstName;
        private string _lastName;
        private Watch _theWatch;

        public Person(string firstname, string lastName)
        {
            this.FirstName = firstname;
            this.LastName = lastName;
            this.TheWatch = null;
        }

        public Watch TheWatch
        {
            get { return this._theWatch; }
            private set { this._theWatch = value; }
        }
        
        public string LastName
        {
            get { return this._lastName; }
            set { this._lastName = value; }
        }

        public string FirstName
        {
            get { return this._firstName; }
            set { this._firstName = value; }
        }

        public void GiveAWatch(Person personWhoGiveTheWatch)
        {
            if (personWhoGiveTheWatch.TheWatch == null) Console.WriteLine(
                $"{personWhoGiveTheWatch.FirstName} {personWhoGiveTheWatch.LastName} don't have a watch, he can't give it.");
            else
            {
                this.TheWatch = personWhoGiveTheWatch.TheWatch;
                personWhoGiveTheWatch.TheWatch = null;
            }
        }

        public void AddWatch(Watch theWatch)
        {
            if (this.TheWatch == null && theWatch.Person == null)
            {
                this.TheWatch = theWatch;
                theWatch.Person = this;
            }
            else if (theWatch.Person != null) Console.WriteLine("The watch already belongs to someone, you can't take it.");
            else Console.WriteLine("You already have a watch he can't get an other.");
        }

        public void AdvanceTheTimeOnYourWatch(int timeToAdvance)
        {
            this.TheWatch.AdvanceTheTime(timeToAdvance);
        }

        public string GivingTheActualyHour()
        {
            if (this.TheWatch != null) return this.TheWatch.Time.ToString("t", new System.Globalization.CultureInfo("fr-FR"));
            else return $"{this.FirstName} {this.LastName} don't have a watch, he can't give the time.";
        }

        public string GivingTheHourWithRedefine()
        {
            if (this.TheWatch == null) return $"{this.FirstName} {this.LastName} don't have a watch, he can't give the time.";
            else
            {
                int hour = this.TheWatch.Hour;
                int minute = this.TheWatch.Minute;
                DateTime tmp = new(1, 1, 1, hour, minute, 0);
                return tmp.ToString("t", new System.Globalization.CultureInfo("fr-FR"));
            }
        }
    }
}