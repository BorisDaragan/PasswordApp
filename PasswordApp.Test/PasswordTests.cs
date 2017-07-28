using System;
using Xunit;
using PA.Model;

namespace PasswordApp.Test
{
    public class PasswordTests
    {
        [Fact]
        public void AddPartTest()
        {
            Password password = new Password();
            PasswordPart pPart = new PasswordPart("123");
            password.AddPart(pPart);

            PasswordPart pPart2 = new PasswordPart("123");
            pPart2.ActionTime = TimeSpan.Zero;
            Assert.Equal(password.PasswordParts[0]== pPart2, true);
        }

        [Fact]
        public void EqualOperatorTest()
        {
            Password password = new Password();
            PasswordPart pPart = new PasswordPart("123");
            password.AddPart(pPart);
            
            Password password2 = new Password();
            PasswordPart pPart2 = new PasswordPart("123");
            password2.AddPart(pPart2);

            Assert.Equal(password == password2, true);
        }
    }
}
