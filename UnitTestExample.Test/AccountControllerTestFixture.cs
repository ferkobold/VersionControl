using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using UnitTestExample.Controllers;

namespace UnitTestExample.Test
{
    public class AccountControllerTestFixture
    {
        [
            Test,
            TestCase("abcd1234", false),
            TestCase("irf@uni-corvinus", false),
            TestCase("irfuni-corvinus.hu", false),
            TestCase("irf@uni-corvinus.hu", true)
        ]
        public void TestValidateEmail(string email, bool expectedResult)
        {
            //Arrange
            var accountController = new AccountController();

            //Act
            var actualResult = accountController.ValidateEmail(email);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        
        [
            Test,
            TestCase("Abcdefgh", true),
            TestCase("ABCD1234", true),
            TestCase("abcd1234", true),
            TestCase("Abcd123", true),
            TestCase("Abcd1234", true)
        ]
        public void TestValidatePassword(string password, bool expectedResult1)
        {
            //Arrange
            var accountController1 = new AccountController();

            //Act
            var actualresult1 = accountController1.ValidatePassword(password);

            //Assert
            Assert.AreEqual(expectedResult1, actualresult1);

        }
    }
}
