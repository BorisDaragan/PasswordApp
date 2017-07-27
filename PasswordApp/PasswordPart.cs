using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA.BO
{
    public class PasswordPart
    {
        public StringBuilder Text { get; set; }
        public DateTime Time { get; set; }

        public PasswordPart(StringBuilder text, DateTime time)
        {
            Text = text;
            Time = time;
        }
    }
}
