using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA.Model
{
    public class PasswordPart
    {
        public StringBuilder Text { get; set; }
        public DateTime Time { get; set; }

        public PasswordPart(string text, DateTime time)
        {
            Text = new StringBuilder(text);
            Time = time;
        }


        public bool Equals(PasswordPart p)
        {
            if ((object)p == null)
            {
                return false;
            }

            if (this.Text == p.Text)//&& a.Time == b.Time)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(PasswordPart a, PasswordPart b)
        {
            if (a.Text.Equals( b.Text) )//&& a.Time == b.Time)
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
