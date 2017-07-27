using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA.BO
{
    public class Password
    { 
        private List<PasswordPart> PasswordParts { get; set; }


        public Password()
        {
            PasswordParts = new List<PasswordPart>();
        }

        public Password(List<PasswordPart> passwordParts)
        {
            PasswordParts = passwordParts;
        }

        public void AddPart(PasswordPart pPart)
        {
            PasswordParts.Add(pPart);
        }
    }
}
