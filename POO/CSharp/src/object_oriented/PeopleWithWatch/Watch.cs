using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleWithWatch
{
    class Watch
    {
        private DateTime _time;
        private Person _person;
        private int _hour;
        private int _minute;

        public Watch(DateTime time)
        {
            this.Time = time;
        }

        public Watch(int hour, int minute)
        {
            try
            {
                Time = new(1, 1, 1, hour, minute, 0);
            }
            catch (Exception)
            {
                Console.WriteLine("Impossible creation.");
            }
        }

        public Watch(Watch otherWath)
        {
            this.Time = otherWath.Time;
        }

        public DateTime Time
        {
            get { return _time; }
            set { _time = value; }
        }

        public Person Person
        {
            get { return _person; }
            set { _person = value; }
        }

        public int Minute
        {
            get { return _minute; }
            private set { _minute = value; }
        }

        public int Hour
        {
            get { return _hour; }
            private set { _hour = value; }
        }
                
        public string AdvanceTheTime(int timeToAdvance)
        {
            this.Hour = this.Time.Hour;
            this.Minute = this.Time.Minute;
            for (int i = timeToAdvance; i > 0; i--)
            {
                if (Minute == 59)
                {
                    this.Hour += 1;
                    this.Minute = 0;
                }
                else this.Minute += 1;
            }
            return $"{Hour:D2}:{Minute:D2}";
        }
    }
}
