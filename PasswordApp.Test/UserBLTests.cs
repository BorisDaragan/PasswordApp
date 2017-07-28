using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using PA.BLL;
using PA.Model;

namespace PasswordApp.Test
{
    public class UserBLTests
    {
        [Fact]
        public void CheckPasswordTest()
        {
            string login = "Login1";
            Password password = new Password();
            password.AddPart(new PasswordPart("123"));
            password.AddPart(new PasswordPart("12"));
            UserBL userBL = new UserBL(login, password);

            Password password2 = new Password();
            password2.AddPart(new PasswordPart("123"));
            password2.AddPart(new PasswordPart("12"));

            Assert.Equal(userBL.CheckPassword(password2), true);
        }
    }
}
