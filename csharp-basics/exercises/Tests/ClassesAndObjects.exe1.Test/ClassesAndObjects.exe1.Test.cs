using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassesAndObjects.exe1.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ChangePrice_Price_true()
        {
            // Arrange
            var a = new ClassesAndObjects_exe1();
            int expected = 10;

            // Act
            var result = a.ChangePrice(expected);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ChangeQuantity_Lists_true()
        {
            // Arrange
            var b = new ClassesAndObjects_exe1();
            int expected = 20;

            // Act
            var result = b.ChangeQuantity(expected);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
