using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arithmetic.exe1.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void is15_2NumbersMakesSum15_True()
        {
            // Arrange
            int a = 5;
            int b = 10;
            bool expected = true;

            // Act
            var result = Arithmetic_exe1.Is15(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void is15_2NumbersDiferencMakes15_True()
        {
            // Arrange
            int a = 20;
            int b = 5;
            bool expected = true;

            // Act
            var result = Arithmetic_exe1.Is15(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void is15_2NumbersEitherMakes15_True()
        {
            // Arrange
            int a = 15;
            int b = 45;
            bool expected = true;

            // Act
            var result = Arithmetic_exe1.Is15(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void is15_2NumbersIsntMakes15_True()
        {
            // Arrange
            int a = 7;
            int b = 2;
            bool expected = false;

            // Act
            var result = Arithmetic_exe1.Is15(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
