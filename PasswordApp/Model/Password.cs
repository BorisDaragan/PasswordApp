using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA.Model
{
    public class Password
    { 
        
        public event EventHandler MyEvent;
        private List<PasswordPart> PasswordParts { get; set; }
        private static int maxSize { get; set; }

        public Password()
        {
            PasswordParts = new List<PasswordPart>();
        }

         static Password()
        {
            maxSize = 100;
        }

        public void AddPart(PasswordPart pPart)
        {
            if (PasswordParts.Count == maxSize)
            {
                throw new ArgumentException("Maximum password length reached.");
            }
            PasswordParts.Add(pPart);
        }

        public static bool operator ==(Password a, Password b)
        {
            if (System.Object.ReferenceEquals(a, b))
            {
                return true;
            }
            
            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }
            return a.PasswordParts.SequenceEqual(b.PasswordParts);
        }

        public static bool operator !=(Password a, Password b)
        {
            return !(a == b);
        }

    }
}
