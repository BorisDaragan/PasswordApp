using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PA.BO;

namespace PA.BLL
{
    public class PasswordPartBL
    {
        internal PasswordPart PasswordPart { get; private set; }

        public PasswordPartBL(string currentPassText)
        {
            PasswordPart = new PasswordPart(new StringBuilder(currentPassText), DateTime.Now);
        }

        public bool IsValid(PasswordPart pPart)
        {
            return true;
        }
    }
}
