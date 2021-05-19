using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserRegistration;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidateFirstName_ReturnTrue()
        {
            string FirstName = "Nilakhi";
            Patterns pattern = new Patterns();
            bool result=  pattern.IsValidFirstName(FirstName);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void ValidateLastName_ReturnTrue()
        {
            string LastName = "Sharma";
            Patterns pattern = new Patterns();
            bool result = pattern.IsValidLastName(LastName);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void ValidateEmail_ReturnTrue()
        {
            string Email = "riyan@gmail.com";
            Patterns pattern = new Patterns();
            bool result = pattern.IsValidEmail(Email);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void ValidatePhoneNo_ReturnTrue()
        {
            string Phone = "91 9778333462";
            Patterns pattern = new Patterns();
            bool result = pattern.IsValidPhoneNo(Phone);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void ValidatePassword_ReturnTrue()
        {
            string Password = "Pass@w0rdyu";
            Patterns pattern = new Patterns();
            bool result = pattern.IsValidPasswordRule(Password);
            Assert.IsTrue(result);
        }
    }
}
