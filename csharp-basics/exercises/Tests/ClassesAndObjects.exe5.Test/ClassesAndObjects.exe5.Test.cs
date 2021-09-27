using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassesAndObjects.exe5.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SetDay_NewDay_true()
        {
            // Arrange
            var a = new ClassesAndObjects_exe5();
            int expected = 20;

            // Act
            var result = a.SetDay(expected);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SetMonth_NewMonth_true()
        {
            // Arrange
            var b = new ClassesAndObjects_exe5();
            int expected = 3;

            // Act
            var result = b.SetMonth(expected);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SetYear_NewYear_true()
        {
            // Arrange
            var c = new ClassesAndObjects_exe5();
            int expected = 1983;

            // Act
            var result = c.SetYear(expected);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
