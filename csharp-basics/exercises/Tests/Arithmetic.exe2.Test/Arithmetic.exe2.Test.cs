using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arithmetic.exe2.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsEven_Number_EvenNumber()
        {
            // Arrange
            int a = 24;
            string expected = "Even number";

            // Act
            var result = Arithmetic_exe2.IsEven(a);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IsEven_Number_OddNumber()
        {
            // Arrange
            int a = 11;
            string expected = "Odd number";

            // Act
            var result = Arithmetic_exe2.IsEven(a);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
