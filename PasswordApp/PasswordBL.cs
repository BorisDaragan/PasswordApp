using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using   PA.BO;

namespace PA.BLL
{
    public class PasswordBL
    {
        public List<PasswordPart> PasswordParts { get; private set; }

        public PasswordBL()
        {
            PasswordParts = new List<PasswordPart>();
        }

        public void Add(PasswordPart pPart)
        {
            PasswordParts.Add(pPart);
        }
        public void Add(PasswordPartBL pPart)
        {
            PasswordParts.Add(pPart.PasswordPart);
        }


        public void Compare()
        {
            
        }

        public void ClearEdit()
        {
            PasswordParts = new List<PasswordPart>();
        }
    }
}
