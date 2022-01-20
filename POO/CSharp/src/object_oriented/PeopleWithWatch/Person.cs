using System;
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
        }

        public Watch TheWatch
        {
            get { return _theWatch; }
            set { _theWatch = value; }
        }
        
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public void GiveAWatch(Person personToGiveTheWatch)
        {
            if (personToGiveTheWatch.TheWatch == null) Console.WriteLine("You don't have a watch, you can't give it away.");
            else
            {
                personToGiveTheWatch.TheWatch = this.TheWatch;
                this.TheWatch = null;
            }
        }

        public void AddWatch(Watch theWatch)
        {
            this.TheWatch = theWatch;
        }

        public string GivingTheTime()
        {
            return this.TheWatch.Time.ToString("t", new System.Globalization.CultureInfo("fr-FR"));
        }
    }
}
