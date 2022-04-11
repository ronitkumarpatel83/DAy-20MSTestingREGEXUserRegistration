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
            Validation validation = new Validation();
            string expected = "Valid";
            string massage = "Ronit";
            //Act
            string actual = validation.FirstNameValidation(massage);
            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
