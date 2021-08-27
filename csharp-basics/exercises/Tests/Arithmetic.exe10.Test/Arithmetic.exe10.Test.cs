using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arithmetic.exe10.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateArea_Choice_Area()
        {
            // Arrange
            int choice = 2;
            double a = 3;
            double b = 5;
            double expected = 15;

            // Act
            var result = Arithmetic_exe10.CalculateArea(choice, a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CalculateArea_Choice_AreaTriangle()
        {
            // Arrange
            int choice = 3;
            double a = 6;
            double b = 6;
            double expected = 18;

            // Act
            var result = Arithmetic_exe10.CalculateArea(choice, a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
