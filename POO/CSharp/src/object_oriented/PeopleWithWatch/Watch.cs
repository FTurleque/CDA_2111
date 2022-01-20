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
        private int _hour;
        private int _minute;

        public Watch(DateTime time)
        {
            this.Time = time;
        }

        public Watch(int hour, int minute)
        {
            this.Time = MakeTimeCreation(hour, minute);
        }

        public Watch(Watch otherWath)
        {
            this.Time = MakeTimeCreation(otherWath.Hour, otherWath.Minute);
        }

        private DateTime MakeTimeCreation(int hour, int minute)
        {
            DateTime tmp = new DateTime(hour / minute);
            return tmp;
        }

        public int Minute
        {
            get { return _minute; }
            set { _minute = value; }
        }

        public int Hour
        {
            get { return _hour; }
            set { _hour = value; }
        }

        public DateTime Time
        {
            get { return _time; }
            set { _time = value; }
        }

        public string AdvanceTheTime(int timeToAdvance)
        {
            Hour = this.Time.Hour;
            Minute = this.Time.Minute;
            for (int i = timeToAdvance; i > 0; i--)
            {
                if (Minute == 59)
                {
                    Hour += 1;
                    Minute = 0;
                }
                else Minute += 1;
            }
            return $"{Hour:D2}:{Minute:D2}";
        }
    }
}
