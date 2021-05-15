using System;
using Xunit;
using Store.Repository;

namespace Store.Tests
{
    public class SecurityTest : BaseTest
    {
        private readonly UserRepository _userRepository;

        public SecurityTest()
        {
            _userRepository = new UserRepository();
        }

        //[Fact]
        //public void LoginCorrectTest()
        //{
        //    var result = _userRepository.Login("Malgusss", "123", out string message);
        //    Assert.True(result != -1, "LoginCorrectTest doesnt work");
        //}

        //[Fact]
        //public void LoginIncorrectPasswordTest()
        //{
        //    var result = _userRepository.Login("Malgusss", "1234", out string message);
        //    Assert.Equal(-1, result);
        //}

        //[Fact]
        //public void LoginIncorrectLoginTest()
        //{
        //    var result = _userRepository.Login("Malgussss", "123", out string message);
        //    Assert.True(result == -1, "LoginIncorrectLoginTest doesnt work");
        //}

        //[Fact]
        //public void LoginIncorrectTest()
        //{
        //    var result = _userRepository.Login("Malgussss", "1234", out string message);
        //    Assert.True(result == -1, "LoginIncorrectTest doesnt work");
        //}
    }
}
