
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
            Password.AddPart(new PasswordPart(passText));
        }

        public void ClearEdit()
        {
            Password = new Password();
        }
        
    }
}
