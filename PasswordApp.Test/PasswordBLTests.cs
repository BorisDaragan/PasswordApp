using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using PA.BLL;

namespace PasswordApp.Test
{
    public class PasswordBLTests
    {
        [Fact]
        public void AddTest()
        {
            PasswordBL passwordBL = new PasswordBL();
            passwordBL.Add("123");
            string s = "123";
            Assert.Equal(s, passwordBL.Password.PasswordParts[0].Text.ToString());
        }

        [Fact]
        public void ClearEditTest()
        {
            PasswordBL passwordBL = new PasswordBL();
            passwordBL.Add("123");
            passwordBL.ClearEdit();
            Assert.Empty(passwordBL.Password.PasswordParts);
        }
    }
}
