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
    }
}
