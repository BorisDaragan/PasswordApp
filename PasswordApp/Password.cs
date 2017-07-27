using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA.Model
{
    public class Password
    { 
        private List<PasswordPart> PasswordParts { get; set; }
        public int maxSize { get;private set; }

        public Password()
        {
            maxSize = 1;
            PasswordParts = new List<PasswordPart>();
        }


        public void AddPart(PasswordPart pPart)
        {
            if (PasswordParts.Count == maxSize)
            {
                throw new ArgumentException("Maximum password length reached.");
            }
            PasswordParts.Add(pPart);
        }
    }
}
