using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arithmetic.exe7.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void gravity_4numbers_NegativeNumber()
        {
            // Arrange
            double gravity = -9.81;
            double initialVelocity = 0.0;
            double fallingTime = 10.0;
            double initialPosition = 0.0;
            double expected = -490.5;

            // Act
            var result = Arithmetic_exe7.gravity(gravity, fallingTime, initialPosition, initialVelocity);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
