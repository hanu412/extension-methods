using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensionMethods.Tests
{
    [TestClass]
    public class StringIsIntegerTest
    {
        [TestMethod]
        public void Should_Fail_For_Null()
        {
            //Arrange
            string input = null;
            //Act
            bool result = input.IsInteger();
            //Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Should_Fail_For_EmptyString()
        {
            //Arrange
            string input = string.Empty;
            //Act
            bool result = input.IsInteger();
            //Assert
            Assert.AreEqual(false, result);
        }


        [TestMethod]
        public void Should_Fail_For_WhiteSpace()
        {
            //Arrange
            string input = " ";
            //Act
            bool result = input.IsInteger();
            //Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Should_Pass_For_ValidInput()
        {
            //Arrange
            string input = "1234";
            //Act
            bool result = input.IsInteger();
            //Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Should_Pass_For_Negative_ValidInput()
        {
            //Arrange
            string input = "-89";
            //Act
            bool result = input.IsInteger();
            //Assert
            Assert.AreEqual(true, result);
        }




    }
}
