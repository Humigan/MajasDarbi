using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Polymorphism.exe1.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SpeedUp_currentSpeed_1()
        {
            // Arrange
            var a = new Polymorphism_exe1();
            int expected = 1;

            // Act
            var result = a.SpeedUp();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SlowDown_currentSpeed_Negative1()
        {
            // Arrange
            var b = new Polymorphism_exe1();
            int expected = -1;

            // Act
            var result = b.SlowDown();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ShowCurrentSpeed_currentSpeed_currentSpeed()
        {
            // Arrange
            var c = new Polymorphism_exe1();
            string expected = "0";

            // Act
            var result = c.ShowCurrentSpeed();

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void UseNitrousOxideEngine_currentSpeed_2()
        {
            // Arrange
            var d = new Polymorphism_exe1();
            int expected = 2;

            // Act
            var result = d.UseNitrousOxideEngine();

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}