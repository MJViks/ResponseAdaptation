using System;
using Xunit;
using RequestAdaptationFatClient;

namespace RequestAdaptation.Tests
{
    public class CryptTests
    {
        [Fact]
        public void GetHash_Password()
        {
            const string password = "Password";
            const string expected = "588+9PF8OZmpTyxvYS6KiI5bECaHjk4ZOYsjvTjsIho=";

            string actual = Crypt.GetHash(password);
            Assert.Equal(expected, actual);
        }

    }
}