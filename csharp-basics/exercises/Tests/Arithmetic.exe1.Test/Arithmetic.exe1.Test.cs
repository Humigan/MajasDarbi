using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arithmetic.exe1.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Sumis15_AandB_true()
        {
            // Arrange
            int a = 5;
            int b = 10;
            bool expected = true;

            // Act
            var result = Arithmetic_exe1.is15(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Difis15_AandB_true()
        {
            // Arrange
            int a = 20;
            int b = 5;
            bool expected = true;

            // Act
            var result = Arithmetic_exe1.is15(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Eitheris15_AandB_true()
        {
            // Arrange
            int a = 15;
            int b = 45;
            bool expected = true;

            // Act
            var result = Arithmetic_exe1.is15(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Isnt15_AandB_true()
        {
            // Arrange
            int a = 7;
            int b = 2;
            bool expected = false;

            // Act
            var result = Arithmetic_exe1.is15(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
