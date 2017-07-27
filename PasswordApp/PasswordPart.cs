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
    }
}
