using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    internal class Duration
    {
        int hours;
        int minutes;
        int seconds;

        public int Hours
        {
            get
            {
                return hours;
            }
            set
            {
                if (hours < 0 || hours > 24)
                {
                    throw new Exception("invalid input");
                }
                else
                {
                    hours = value;
                }
            }
        }
        public int Minutes
        {
            get
            {
                return minutes;
            }
            set
            {
                if (minutes < 0 || hours > 60)
                {
                    throw new Exception("invalid input");
                }
                else
                {
                    minutes = value;
                }
            }
        }
        public int Seconds
        {
            get
            {
                return seconds;
            }
            set
            {
                if (hours < 0 || hours > 60)
                {
                    throw new Exception("invalid input");
                }
                else
                {
                    seconds = value;
                }
            }
        }
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            Minutes = (totalSeconds % 3600) / 60;
            seconds = totalSeconds % 60;
        }
        public override string ToString()
        {
            return $"time: {hours}:{minutes}:{seconds}";
        }
        public static Duration operator +(Duration a, Duration b)
        {
            return new Duration(a.Hours + b.Hours, a.Minutes + b.Minutes, a.Seconds + b.Seconds);
        }
        public static Duration operator +(Duration a, int totalSeconds)
        {
            Duration b = new Duration(totalSeconds);
            return new Duration(a.Hours + b.Hours, a.Minutes + b.Minutes, a.Seconds + b.Seconds);
        }
        public static Duration operator +(int totalSeconds, Duration b)
        {
            Duration a = new Duration(totalSeconds);
            return new Duration(a.Hours + b.Hours, a.Minutes + b.Minutes, a.Seconds + b.Seconds);
        }
        public static Duration operator -(Duration a, Duration b)
        {
            return new Duration(a.Hours - b.Hours, a.Minutes - b.Minutes, a.Seconds - b.Seconds);
        }
        public static Duration operator -(Duration a, int totalSeconds)
        {
            Duration b = new Duration(totalSeconds);
            return new Duration(a.Hours - b.Hours, a.Minutes - b.Minutes, a.Seconds - b.Seconds);
        }
        public static Duration operator -(int totalSeconds, Duration b)
        {
            Duration a = new Duration(totalSeconds);
            return new Duration(a.Hours - b.Hours, a.Minutes - b.Minutes, a.Seconds - b.Seconds);
        }
        public static Duration operator ++(Duration a)
        {
            //a.Hours++;
            //a.Minutes++;
            //a.Seconds++;
            //return a;
            if(a.Minutes <60)
            {
                a.Minutes++;
            }else
            {
                a.Minutes = 0;
                a.hours++;
            }

            return a;
        }
        public static Duration operator --(Duration a)
        {
            //a.Hours--;
            //a.Minutes--;
            //a.Seconds--;
            //return a;
            if (a.Minutes >0)
            {
                a.Minutes--;
            }
            else
            {
                a.Minutes = 59;
                a.hours--;
            }
            
            return a;
        }
        public static bool operator >(Duration a, Duration b)
        {
            if (a.Hours > b.Hours)
                return true;
            else if (a.Hours == b.Hours)
            {
                if (a.Minutes > b.Minutes)
                    return true;
                else if (a.Minutes == b.Minutes)
                {
                    if (a.Seconds > b.Seconds)
                        return true;
                }
            }

            return false;
        }
        public static bool operator <(Duration a, Duration b)
        {
            if (a.Hours < b.Hours)
                return true;
            else if (a.Hours == b.Hours)
            {
                if (a.Minutes < b.Minutes)
                    return true;
                else if (a.Minutes == b.Minutes)
                {
                    if (a.Seconds < b.Seconds)
                        return true;
                }
            }

            return false;
        }
        public static bool operator >= (Duration a, Duration b) 
        {
            if (a.Hours >= b.Hours)
                return true;
            else if (a.Minutes >= b.Minutes)
                return true;
            else if (a.Seconds >= b.Seconds)
                return true;
            else
                return false;
        }
        public static bool operator <=(Duration a, Duration b)
        {
            if (a.Hours <= b.Hours)
                return true;
            else if (a.Minutes <= b.Minutes)
                return true;
            else if (a.Seconds <= b.Seconds)
                return true;
            else
                return false;
        }
        public static implicit operator bool(Duration a)
        {
            if ((a.Hours == 0) && (a.Minutes == 0) && (a.Seconds == 0))
                return false;
            return true;
        }
        public static explicit operator DateTime(Duration a)
        {
            return new DateTime(0,0,0,a.Hours,a.Minutes,a.Seconds);
        }

    }
}
