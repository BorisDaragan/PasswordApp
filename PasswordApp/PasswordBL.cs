using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using   PA.Model;

namespace PA.BLL
{
    public class PasswordBL
    {
        public Password Password { get; set; }

        public PasswordBL()
        {
            Password = new Password();
        }

        public void Add(string passText)
        {
            Password.AddPart(new PasswordPart(passText, DateTime.Now));
        }

        public void ClearEdit()
        {
            Password = new Password();
        }
        
    }
}
