using PA.Model;
using System;
using Xunit;

namespace PasswordApp.Test
{
    public class PasswordPartTests
    {
        [Fact]
        public void EqualOperatorTest()
        {
            PasswordPart pPart1 = new PasswordPart("123");
            pPart1.ActionTime = TimeSpan.FromMilliseconds(1000);
            PasswordPart pPart2 = new PasswordPart("123");
            pPart2.ActionTime = TimeSpan.FromMilliseconds(1001);

            Assert.Equal(pPart1 == pPart2, true);
        }
        

    }
}
