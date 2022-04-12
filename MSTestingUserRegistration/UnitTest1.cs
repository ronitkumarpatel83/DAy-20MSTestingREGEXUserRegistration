using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day_20_MSTestingREGEXUserRegistration;
using System;

namespace MSTestingUserRegistration
{
    [TestClass]
    public class UserRegistrationREGEX
    {
        [TestMethod]
        public void GivenFirstName()
        {
            //Arrange
            Validation firstname = new Validation();
            string expected = "Valid";
            string massage = "Ronit";
            //Act
            string actual = firstname.FirstNameValidation(massage);
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void GivenLastName()
        {
            //Arrange
            Validation lastname = new Validation();
            string expected = "Valid";
            string massage = "Patel";
            //Act
            string actual = lastname.LastNameValidation(massage);
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void GiveEmail()
        {
            //Arrange
            Validation email = new Validation();
            string expected = "Valid";
            string massage = "ronitkumarpatel83@gmail.com";
            //Act
            string actual = email.EmailValidation(massage);
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void GiveMobileNumber()
        {
            //Arrange
            Validation email = new Validation();
            string expected = "Valid";
            string massage = "91 7008427274";
            //Act
            string actual = email.MobileNumberValidation(massage);
            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void GivePassword()
        {
            //Arrange
            Validation email = new Validation();
            string expected = "Valid";
            string massage = "AbCdEfGhIjKl@1234";
            //Act
            string actual = email.Password(massage);
            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
