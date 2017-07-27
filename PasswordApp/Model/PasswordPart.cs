using System;
using System.Text;

namespace PA.Model
{
    public class PasswordPart
    {
        public StringBuilder Text { get; set; }
        public TimeSpan ActionTime { get; set; }
        private static int TimeAccuracyMilliSeconds { get; set; }

        public PasswordPart(string text)
        {
            Text = new StringBuilder(text);
        }

        static PasswordPart()
        {
            TimeAccuracyMilliSeconds = 1000;
        }

        public static void SetAccuracy(int accuracy)
        {
            TimeAccuracyMilliSeconds = accuracy;
        }
        
        
        
        public static bool operator ==(PasswordPart a, PasswordPart b)
        {
            if (a.Text.Equals( b.Text) &&  Math.Abs( (a.ActionTime - b.ActionTime).TotalMilliseconds) <= TimeAccuracyMilliSeconds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(PasswordPart a, PasswordPart b)
        {
            return !(a == b);
        }
    }
}
