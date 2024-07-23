using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Third_Project
{
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
            Normalize();
        }
        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            Minutes = (totalSeconds % 3600) / 60;
            Seconds = totalSeconds % 60;
        }
        public void Normalize()
        {
            if (Seconds < 0)
            {
                int minuteBorrow = (Math.Abs(Seconds) + 59) / 60;
                Seconds = (60 + Seconds % 60) % 60;
                Minutes -= minuteBorrow;
            }
            if (Minutes < 0)
            {
                int hourBorrow = (Math.Abs(Minutes) + 59) / 60;
                Minutes = (60 + Minutes % 60) % 60;
                Hours -= hourBorrow;
            }
        }
        public override string ToString()
        {
            if (Hours > 0)
                return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
            else if (Minutes > 0)
                return $"Minutes: {Minutes}, Seconds: {Seconds}";
            else
                return $"Seconds: {Seconds}";
        }
        public override bool Equals(object obj)
        {
            if (obj is Duration other)
            {
                return Hours == other.Hours && Minutes == other.Minutes && Seconds == other.Seconds;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }
        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds + d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds);
        }
        public static Duration operator +(Duration d, int seconds)
        {
            return new Duration(d.Hours * 3600 + d.Minutes * 60 + d.Seconds + seconds);
        }
        public static Duration operator +(int seconds, Duration d)
        {
            return new Duration(d.Hours * 3600 + d.Minutes * 60 + d.Seconds + seconds);
        }

        public static Duration operator ++(Duration d)
        {
            return new Duration(d.Hours, d.Minutes + 1, d.Seconds);
        }
        public static Duration operator --(Duration d)
        {
            return new Duration(d.Hours, d.Minutes - 1, d.Seconds);
        }
        public static Duration operator -(Duration d1, Duration d2)
        {
            return new Duration(d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds - (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds));
        }
        public static bool operator >(Duration d1, Duration d2)
        {
            return d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds > d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;
        }
        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds < d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;
        }
        public static bool operator <=(Duration d1, Duration d2)
        {
            return d1 < d2 || d1 == d2;
        }
        public static bool operator >=(Duration d1, Duration d2)
        {
            return d1 > d2 || d1 == d2;
        }
        public static bool operator ==(Duration d1, Duration d2)
        {
            return d1.Equals(d2);
        }
        public static bool operator !=(Duration d1, Duration d2)
        {
            return !d1.Equals(d2);
        }
        public static explicit operator DateTime(Duration d)
        {
            return new DateTime(1, 1, 1, d.Hours, d.Minutes, d.Seconds);
        }
    }
}
