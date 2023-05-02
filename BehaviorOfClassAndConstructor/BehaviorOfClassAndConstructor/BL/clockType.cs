using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviorOfClassAndConstructor.BL
{

    class clockType
    {
        public int hours;
        public int minutes;
        public int seconds;

        public clockType()
        {
            hours = 0;
            minutes = 0;
            seconds = 0;
        }
        public clockType(int hours)
        {
            this.hours = hours;
        }
        public clockType(int hours, int minutes)
        {
            this.hours = hours;
            this.minutes = minutes;
        }
        public clockType(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }
        public void incrementSecond()
        {
            seconds++;
        }
        public void incrementHour()
        {
            hours++;
        }
        public void incrementMinute()
        {
            minutes++;
        }
        public void printTime()
        {
            Console.WriteLine(hours + " " + minutes + " " + seconds);
        }
        public bool isEqual(int h, int m, int s)
        {
            if (hours == h && minutes == m && seconds == s)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isEqual(clockType t)
        {
            if (hours == t.hours && minutes == t.minutes && seconds == t.seconds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
    class clockType2
        {
        public int hours;
        public int minutes;
        public int seconds;
        
        public clockType2()
        {
            hours = 0;
            minutes = 0;
            seconds = 0;
        }
        public clockType2(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
        }
        public void timeP()
        {
            Console.Write(hours + " " + minutes + " " + seconds);
        }
        public int sec()
        {
            int second = hours * 3600 + minutes * 60 + seconds;
            return second;
        }
    }
}
